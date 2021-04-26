using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // [Browsable(true)]

namespace CommonControlPlus
{
    /// <summary>
    /// 数値用の拡張版テキストボックス (ジェネリッククラス)
    /// </summary>
    /// <typeparam name="Type">数値の型 (int, double, decimal のいずれか)</typeparam>
    public class TextBoxNumeric<Type> : TextBoxPlus where Type : struct, IComparable, IFormattable
    {
        #region イベント

        /// <summary>
        /// 入力値チェック関数の型
        /// </summary>
        /// <param name="inputVal">入力された数値</param>
        /// <returns>OK(true)かNG(false)か</returns>
        public delegate bool InputValueCheckFunction(Type inputVal);

        /// <summary>
        /// 入力値チェック関数をここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event InputValueCheckFunction InputValueCheck = null;

        #endregion

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
        public Type? Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                this.Text = value.ToString();
            }
        }

        #endregion

        #region 内部処理

        // 数値
        private Type? _Value = null;

        // 既定の入力値チェック
        private bool DefaultInputCheck(Type inputVal)
        {
            // 最小値・最大値のチェック
            if ((MinValue != null) && (MaxValue != null))
            {
                if ((inputVal.CompareTo((Type)MinValue) < 0) ||
                   (inputVal.CompareTo((Type)MaxValue) > 0))
                {
                    ErrorMessage = MinValue.ToString() + "～" +
                                   MaxValue.ToString() + "の範囲の値を入力してください";
                    return false;
                }
            }
            // 最小値のみのチェック
            else if (MinValue != null)
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
            if ((StepValue != null) && (StepValue != (dynamic)0) &&
                (((dynamic)inputVal % StepValue) != 0))
            {
                ErrorMessage = StepValue.ToString() + "の倍数を入力してください";
                return false;
            }
            return true;
        }

        // 入力チェックと値の更新
        override protected bool InputCheckAndUpdate(string text)
        {
            bool result = true;
            Type inputVal = (dynamic)0;
            try
            {
                // 数値への変換
                var converter = TypeDescriptor.GetConverter(typeof(Type));
                if (converter != null)
                {
                    inputVal = (Type)converter.ConvertFromString(text);
                }
                else
                {
                    ErrorMessage = "予期しないエラーが発生しました";
                    result = false;
                }
            }
            catch
            {
                if (typeof(Type) == typeof(int))
                {
                    ErrorMessage = "整数値を入力してください";
                }
                else
                {
                    ErrorMessage = "数値を入力してください";
                }
                result = false;
            }

            if (result == true)
            {
                if (InputValueCheck != null)
                {
                    // ユーザー定義の入力値チェック
                    result = InputValueCheck(inputVal);
               }
                else
               {
                    // 既定の入力値チェック
                    result = DefaultInputCheck(inputVal);
                }
            }

            if (result)
            {
                _Value = inputVal; // 値を更新
            }
            else
            {
                ErrorMessageOutput();
                this.Text = _Value.ToString(); // 前回のテキストに戻す
            }
            return result;
        }

        #endregion
    }

    /// <summary>
    /// double型数値用の拡張版テキストボックス
    /// </summary>
    public class TextBoxDouble : TextBoxNumeric<double>
    {
    }

    /// <summary>
    /// decimal型数値用の拡張版テキストボックス
    /// </summary>
    public class TextBoxDecimal : TextBoxNumeric<decimal>
    {
    }

    /// <summary>
    /// int型数値用の拡張版テキストボックス
    /// </summary>
    public class TextBoxInteger : TextBoxNumeric<int>
    {
    }
}
