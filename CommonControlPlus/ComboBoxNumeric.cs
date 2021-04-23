using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel; // [Browsable(true)]

namespace CommonControlPlus
{
    /// <summary>
    /// 数値用の拡張版コンボボックス (ジェネリッククラス)
    /// </summary>
    /// <typeparam name="Type">数値の型 (int, double, decimal のいずれか)</typeparam>
    public abstract class ComboBoxNumeric<Type> : ComboBoxPlus where Type : struct, IComparable, IFormattable
    {
        #region プロパティ

        /// <summary>
        /// 入力できる最大値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type? MaxValue { set; get; } = null;

        /// <summary>
        /// 入力できる最小値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type? MinValue { set; get; } = null;

        /// <summary>
        /// 入力できる値の最小幅
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type? StepValue { set; get; } = null;

        /// <summary>
        /// 数値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type Value
        {
            get
            {
                // 既存のリストから選択されている場合はその値を返す
                if(this.SelectedItem != null)
                {
                    return (Type)this.SelectedItem;
                }
                // テキスト入力された場合は数値に変換して返す
                else
                {
                    var converter = TypeDescriptor.GetConverter(typeof(Type));
                    if (converter != null)
                    {
                        Type value;
                        try
                        {
                            value = (Type)converter.ConvertFromString(this.Text);
                            return value;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                    else
                    {
                        throw new  InvalidOperationException("予期しないエラーです");
                    }
                }
            }
            set
            {
                SelectOrAddItem(value);
            }
        }

        #endregion

        #region 内部処理

        override protected bool DefaultInputCheck(string text)
        {
            // 数値への変換
            Type inputVal;
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(Type));
                if (converter != null)
                {
                    inputVal = (Type)converter.ConvertFromString(text);
                }
                else
                {
                    ErrorMessage = "予期しないエラーが発生しました";
                    return false;
                }
            }
            catch
            {
                if(typeof(Type) == typeof(int))
                {
                    ErrorMessage = "整数値を入力してください";
                }
                else
                {
                    ErrorMessage = "数値を入力してください";
                }
                return false;
            }

            // 最小値・最大値のチェック
            if((MinValue != null) && (MaxValue != null))
            {
                if((inputVal.CompareTo((Type)MinValue) < 0) ||
                   (inputVal.CompareTo((Type)MaxValue) > 0) )
                {
                    ErrorMessage = MinValue.ToString() + "～" + 
                                   MaxValue.ToString() + "の範囲の値を入力してください";
                    return false;
                }
            }
            // 最小値のみのチェック
            else if(MinValue != null)
            {
                if (inputVal.CompareTo((Type)MinValue) < 0)
                {
                    ErrorMessage = MinValue.ToString() + "以上の値を入力してください";
                    return false;
                }
            }
            // 最大値のみのチェック
            else if (MaxValue != null)
            {
                if (inputVal.CompareTo((Type)MaxValue) > 0)
                {
                    ErrorMessage = MaxValue.ToString() + "以下の値を入力してください";
                    return false;
                }
            }

            // 最小ステップのチェック
            if ((StepValue != null) && (!Devidible(inputVal, (Type)StepValue)))
            {
                ErrorMessage = StepValue.ToString() + "の倍数を入力してください";
                return false;
            }
            return true;
        }

        // 剰余がゼロ(割り切れる)かチェック
        abstract protected bool Devidible(Type a, Type b);
 
        #endregion
    }

    /// <summary>
    /// double型数値用の拡張版コンボボックス
    /// </summary>
    public class ComboBoxDouble : ComboBoxNumeric<double>
    {
        // 剰余がゼロ(割り切れる)かチェック
        override protected bool Devidible(double a, double b)
        {
            return ((a % b) == 0);
        }
    }

    /// <summary>
    /// decimal型数値用の拡張版コンボボックス
    /// </summary>
    public class ComboBoxDecimal : ComboBoxNumeric<decimal>
    {
        // 剰余がゼロ(割り切れる)かチェック
        override protected bool Devidible(decimal a, decimal b)
        {
            return ((a % b) == 0);
        }
    }

    /// <summary>
    /// int型数値用の拡張版コンボボックス
    /// </summary>
    public class ComboBoxInteger : ComboBoxNumeric<int>
    {
        // 剰余がゼロ(割り切れる)かチェック
        override protected bool Devidible(int a, int b)
        {
            return ((a % b) == 0);
        }
    }
}
