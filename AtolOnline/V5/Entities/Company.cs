using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class Company
    {
        /// <summary>
        /// Электронный адрес покупателя
        /// </summary>
        [JsonProperty("email")]
        [EmailAddress]
        [Required]
        [StringLength(maximumLength: 64)]
        public string Email { get; set; }


        /// <summary>
        /// Система налогообложения
        /// </summary>
        [Required]
        [JsonProperty("sno")]
        public string SNO { get; set; }

        /// <summary>
        /// ИНН организации. Используется для предотвращения ошибочных 
        /// регистраций чеков на ККТ зарегистрированных с другим ИНН(сравнивается со значением в ФН).
        /// </summary>
        [JsonProperty("inn")]
        [Required]
        [StringLength(maximumLength: 12)]
        public string INN { get; set; }

        /// <summary>
        /// Место расчетов
        /// </summary>
        [JsonProperty("payment_address")]
        [Required]
        [StringLength(maximumLength: 256)]
        public string PaymentAddress { get; set; }
    }
}
