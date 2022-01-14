using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class AdditionalUserProps
    {
        /// <summary>
        /// Наименование дополнительного реквизита пользователя.
        /// </summary>
        [Required]
        [StringLength(maximumLength:64)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Значение дополнительного реквизита пользователя
        /// </summary>
        [Required]
        [StringLength(maximumLength: 256)]
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
