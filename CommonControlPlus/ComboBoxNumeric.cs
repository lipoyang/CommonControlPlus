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
    /// 数値用の拡張版コンボボックス
    /// </summary>
    /// <typeparam name="Type">数値の型</typeparam>
    public class ComboBoxNumeric<Type> : ComboBoxPlus where Type : struct, IComparable, IFormattable
    {
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

    }

    /// <summary>
    /// double型数値用の拡張版コンボボックス
    /// </summary>
    public class ComboBoxDouble : ComboBoxNumeric<double>
    {
    }

    /// <summary>
    /// decimal型数値用の拡張版コンボボックス
    /// </summary>
    public class ComboBoxDecimal : ComboBoxNumeric<decimal>
    {
    }

    /// <summary>
    /// int型数値用の拡張版コンボボックス
    /// </summary>
    public class ComboBoxInteger : ComboBoxNumeric<int>
    {

        override protected bool InputCheck()
        {
            int inputVal;
            try
            {
                inputVal = int.Parse(this.Text);
            }
            catch
            {
                ErrorMessageBox_Show("整数値を入力してください");
                return false;
            }
            if ((inputVal < MinValue) || (inputVal > MaxValue))
            {
                ErrorMessageBox_Show(MinValue.ToString() + "～" + MaxValue.ToString() + "の範囲を入力してください");
                return false;
            }
            if ((StepValue != 0) && ((inputVal % StepValue) != 0))
            {
                ErrorMessageBox_Show(StepValue.ToString() + "の倍数を入力してください");
                return false;
            }
            return true;
        }
    }
}
