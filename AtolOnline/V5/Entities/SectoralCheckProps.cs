using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class SectoralCheckProps
    {
        /// <summary>
        /// Идентификатор ФОИВ
        /// </summary>
        [JsonProperty("federal_id")]
        [Required]
        public string FederalId { get; set; }

        /// <summary>
        /// Дата нормативного акта федерального органа исполнительной власти, 
        /// регламентирующего порядок заполнения реквизита «значение отраслевого реквизита»<br />
        /// Значение в формате в формате ДД.ММ.ГГГГ
        /// </summary>
        [JsonProperty("date")]
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Номер нормативного акта федерального органа исполнительной власти, 
        /// регламентирующего порядок заполнения реквизита «значение отраслевого реквизита» 
        /// </summary>
        [JsonProperty("number")]
        [StringLength(maximumLength:32)]
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Состав значений, определенных нормативного актом федерального органа исполнительной власти
        /// </summary>
        [JsonProperty("value")]
        [StringLength(maximumLength:256)]
        [Required]
        public string Value { get; set; }
    }
}
