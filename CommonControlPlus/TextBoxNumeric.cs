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
        public InputValueCheckFunction InputValueCheck = null; // あえてeventでなくdelegateとする

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
        public Type Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                this.Text = ((dynamic)_Value).ToString(this.FormatString);
                OldText = this.Text;
            }
        }
        
        /// <summary>
        /// 数値書式指定文字列
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string FormatString
        {
            get
            {
                return _FormatString;
            }
            set
            {
                _FormatString = value;
                this.Text = ((dynamic)_Value).ToString(this.FormatString);
                OldText = this.Text;
            }
        }

        #endregion

        #region 内部処理

        // 数値
        private Type _Value = (dynamic)0;
        
        // 数値書式指定文字列
        private string _FormatString = "";

        // 既定の入力値チェック
        private bool DefaultInputCheck(Type inputVal)
        {
            dynamic min = MinValue;
            dynamic max = MaxValue;
            dynamic step = StepValue;

            // 最小値・最大値のチェック
            if ((min != null) && (max != null))
            {
                if ((inputVal.CompareTo(min) < 0) ||
                   (inputVal.CompareTo(max) > 0))
                {
                    ErrorMessage = min.ToString(this.FormatString) + "～" +
                                   max.ToString(this.FormatString) + "の範囲の値を入力してください";
                    return false;
                }
            }
            // 最小値のみのチェック
            else if (min != null)
            {
                if (inputVal.CompareTo(min) < 0)
                {
                    ErrorMessage = min.ToString(this.FormatString) + "以上の値を入力してください";
                    return false;
                }
            }
            // 最大値のみのチェック
            else if (MaxValue != null)
            {
                if (inputVal.CompareTo(max) > 0)
                {
                    ErrorMessage = max.ToString(this.FormatString) + "以下の値を入力してください";
                    return false;
                }
            }
            // 最小ステップのチェック
            if ((step != null) && (step != 0) &&
                (((dynamic)inputVal % step) != 0))
            {
                ErrorMessage = step.ToString(this.FormatString) + "の倍数を入力してください";
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
            }
            this.Text = ((dynamic)_Value).ToString(this.FormatString);
            OldText = this.Text;
            
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
