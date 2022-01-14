namespace AtolOnline.V5.Enums
{

    public struct PaymentMethods
    {
        /// <summary>
        /// Предоплата 100%. Полная предварительная оплата до момента передачи предмета расчета
        /// </summary>
        public static readonly string FullPrepayment = "full_prepayment";

        /// <summary>
        /// Предоплата. Частичная предварительная оплата до момента передачи предмета расчета.
        /// </summary>
        public static readonly string Prepayment = "prepayment";

        /// <summary>
        /// Аванс
        /// </summary>
        public static readonly string Advance = "advance";

        /// <summary>
        /// Полный расчет. Полная оплата, в том числе с учетом аванса (предварительной оплаты) в момент передачи предмета расчета
        /// </summary>
        public static readonly string FullPayment = "full_payment";

        /// <summary>
        /// Частичный расчет и кредит. Частичная оплата предмета расчета в момент его передачи с последующей оплатой в кредит
        /// </summary>
        public static readonly string PartialPayment = "partial_payment";

        /// <summary>
        /// Передача в кредит. Передача предмета расчета без его оплаты в момент его передачи с последующей оплатой в кредит
        /// </summary>
        public static readonly string Credit = "сredit";

        /// <summary>
        /// Частичный расчет и кредит. Частичная оплата предмета расчета в момент его передачи с последующей оплатой в кредит
        /// </summary>
        public static readonly string CreditPayment = "credit_payment";
    }
}
