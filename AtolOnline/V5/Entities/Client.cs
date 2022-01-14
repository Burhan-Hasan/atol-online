using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class Client
    {
        /// <summary>
        /// Электронный адрес покупателя.
        /// </summary>
        [JsonProperty("email")]
        [EmailAddress]
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
        /// ИНН покупателя (клиента).
        /// </summary>
        [JsonProperty("email")]
        [StringLength(maximumLength: 12)]
        public string INN { get; set; }


        /// <summary>
        /// Дата рождения покупателя (клиента) в формате ДД.ММ.ГГГГ (ровно 10 символов).
        /// </summary>
        [JsonProperty("birthdate")]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Числовой код страны, гражданином которой является покупатель (клиент). 
        /// Код страны указывается в соответствии с Общероссийским классификатором стран мира ОКСМ. 
        /// </summary>
        [JsonProperty("citizenship")]
        [StringLength(maximumLength: 3)]
        public string Citizenship { get; set; }

        /// <summary>
        /// Числовой код вида документа, удостоверяющего личность. Может принимать только значения из справочника.
        /// </summary>
        [JsonProperty("document_code")]
        [StringLength(maximumLength: 2)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// Реквизиты документа, удостоверяющего личность.
        /// </summary>
        [JsonProperty("document_data")]
        [StringLength(maximumLength: 64)]
        public string DocumentData { get; set; }

        /// <summary>
        /// Адрес покупателя (клиента), грузополучателя.
        /// </summary>
        [JsonProperty("address")]
        [StringLength(maximumLength: 256)]
        public string Address { get; set; }
    }
}
