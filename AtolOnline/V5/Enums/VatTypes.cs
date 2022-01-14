using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.V5.Enums
{

    /// <summary>
    /// Устанавливает номер налога в ККТ.
    /// </summary>
    public struct VatTypes
    {
        /// <summary>
        /// без НДС
        /// </summary>
        public static readonly string None = "none";

        /// <summary>
        /// НДС по ставке 0%
        /// </summary>
        public static readonly string Vat0 = "vat0";

        /// <summary>
        /// НДС чека по ставке 10%
        /// </summary>
        public static readonly string Vat10 = "vat10";

        /// <summary>
        /// НДС чека по расчетной ставке 10/110
        /// </summary>
        public static readonly string Vat110 = "vat110";

        /// <summary>
        /// НДС чека по ставке 20%
        /// </summary>
        public static readonly string Vat20 = "vat20";

        /// <summary>
        /// НДС чека по расчетной ставке 20/120
        /// </summary>
        public static readonly string Vat120 = "vat120";
    }
}
