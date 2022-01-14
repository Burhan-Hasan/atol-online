using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AtolOnline.V5.Entities
{
    public class OperatingCheckProps
    {
        /// <summary>
        /// Идентификатор операции<br />
        /// Принимает значения «0» до определения значения реквизита ФНС России.
        /// </summary>
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Данные операции<br />
        /// Максимальная длина строки – 64 символа
        /// </summary>
        [Required]
        [StringLength(maximumLength: 64)]
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Дата и время операции в формате: «dd.mm.yyyy HH:MM:SS» 
        /// </summary>
        [Required]
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
