using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class Customer
    {
        /// <summary>
        /// Электронный адрес покупателя
        /// </summary>
        [JsonProperty("email")]
        [StringLength(maximumLength: 64)]
        public string Email { get; set; }


        /// <summary>
        /// <para>
        ///     Телефон покупателя
        /// </para>
        /// <para>
        ///    Номер телефона необходимо передать вместе с кодом страны без пробелов и
        ///    дополнительных символов, кроме символа «+» (номер «+371 2 1234567» 
        ///    необходимо передать как «+37121234567»).
        /// </para>
        /// </summary>
        [JsonProperty("phone")]
        [StringLength(maximumLength: 19)]
        public string Phone { get; set; }


        /// <summary>
        /// Наименование покупателя (клиента).
        /// </summary>
        [JsonProperty("email")]
        [StringLength(maximumLength: 256)]
        public string Name { get; set; }


        /// <summary>
        /// ИНН покупателя (клиента)
        /// </summary>
        [JsonProperty("email")]
        [StringLength(maximumLength: 12)]
        public string INN { get; set; }
    }
}
