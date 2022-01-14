using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    /// <summary>
    /// Атрибуты налога на позицию.
    /// </summary>
    public class Vat
    {
        /// <summary>
        /// Устанавливает номер налога в ККТ
        /// <para>Enum -> PaymentMethods</para>
        /// </summary>
        [JsonProperty("type")]
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Сумма налога позиции в рублях:<br />
        /// ㅤ*целая часть не более 8 знаков<br />
        /// ㅤ*дробная часть не более 2 знаков
        /// </summary>
        [JsonProperty("sum")]
        public decimal Sum { get; set; }
    }
}
