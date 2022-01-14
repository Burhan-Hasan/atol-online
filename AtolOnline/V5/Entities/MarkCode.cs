using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.V5.Entities
{
    /// <summary>
    /// См 35 <see href="https://online.atol.ru/files/API_atol_online_v5.pdf"/>
    /// </summary>
    public class MarkCode
    {
        public string Unknown { get; set; }
        public string Ean8 { get; set; }
        public string Ean13 { get; set; }
        public string Itf14 { get; set; }
        public string Gs1m { get; set; }
        public string Short { get; set; }
        public string Fur { get; set; }
        public string Egais20 { get; set; }
        public string Egais30 { get; set; }
    }
}
