using AtolOnline.V5.Enums;
using Newtonsoft.Json;

namespace AtolOnline.V5.Entities
{
    public class Payment
    {
        [JsonProperty("type")]
        public PaymentType Type { get; set; }

        /// <summary>
        /// Сумма к оплате в рублях:<br />
        /// ㅤ*целая часть не более 8 знаков<br />
        /// ㅤ*дробная часть не более 2 знаков
        /// </summary>
        [JsonProperty("sum")]
        public decimal Sum { get; set; }
    }
}
