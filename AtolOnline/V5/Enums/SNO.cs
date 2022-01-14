namespace AtolOnline.V5.Enums
{
    /// <summary>
    /// Типы налогообложения
    /// </summary>
    public struct SNO
    {
        /// <summary>
        /// общая СН
        /// </summary>
        public static readonly string OSN = "osn";

        /// <summary>
        /// упрощенная СН (доходы)
        /// </summary>
        public static readonly string USN_INCOME = "usn_income";

        /// <summary>
        /// упрощенная СН (доходы минус расходы)
        /// </summary>
        public static readonly string USN_INCOME_OUTCOME = "usn_income_outcome";

        /// <summary>
        /// единый налог на вмененный доход
        /// </summary>
        public static readonly string ENVD = "envd";

        /// <summary>
        /// единый сельскохозяйственный налог
        /// </summary>
        public static readonly string ESN = "esn";

        /// <summary>
        /// патентная СН
        /// </summary>
        public static readonly string PATENT = "patent";
    }
}
