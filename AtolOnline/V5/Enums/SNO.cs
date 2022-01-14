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
        public static string OSN = "osn";

        /// <summary>
        /// упрощенная СН (доходы)
        /// </summary>
        public static string USN_INCOME = "usn_income";

        /// <summary>
        /// упрощенная СН (доходы минус расходы)
        /// </summary>
        public static string USN_INCOME_OUTCOME = "usn_income_outcome";

        /// <summary>
        /// единый налог на вмененный доход
        /// </summary>
        public static string ENVD = "envd";

        /// <summary>
        /// единый сельскохозяйственный налог
        /// </summary>
        public static string ESN = "esn";

        /// <summary>
        /// патентная СН
        /// </summary>
        public static string PATENT = "patent";
    }
}
