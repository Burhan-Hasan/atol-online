using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.V5.Enums
{
    public enum PaymentType
    {
        /// <summary>
        /// наличные
        /// </summary>
        Cash = 0,

        /// <summary>
        /// безналичный
        /// </summary>
        Cashless = 1,

        /// <summary>
        /// предварительная оплата (зачет аванса и (или) предыдущих платежей)
        /// </summary>
        Prepayment = 2,

        /// <summary>
        /// постоплата (кредит)
        /// </summary>
        Postpaid = 3,

        /// <summary>
        /// иная форма оплаты (встречное предоставление)
        /// </summary>
        Other = 4
    }
}
