using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class Receipt
    {
        /// <summary>
        /// Сведения о покупателе (клиенте)
        /// </summary>
        [JsonProperty("client")]
        public Client Client { get; set; }

        /// <summary>
        /// Сведения о компании (продавец)
        /// </summary>
        [JsonProperty("company")]
        public Company Company { get; set; }

        /// <summary>
        /// Заполняется для каждого добавленного товара
        /// </summary>
        [JsonProperty("items")]
        public List<Item> Items { get; set; }


        /// <summary>
        /// Оплаты. Ограничение по количеству от 1 до 10
        /// </summary>
        [JsonProperty("payments")]
        [Required]
        public List<Payment> Payments { get; set; }


        /// <summary>
        /// Атрибуты налогов на чек. Ограничение по количеству от 1 до 6
        /// Необходимо передать либо сумму налога на позицию, либо сумму налога на чек. 
        /// Если будет переданы и сумма налога на позицию и сумма 
        /// налога на чек, сервис учтет только сумму налога на чек.
        /// </summary>
        [JsonProperty("vats")]
        public List<Vat> Vats { get; set; }

        /// <summary>
        /// ФИО кассира. Максимальная длина строки – 64 символа.
        /// </summary>
        [StringLength(maximumLength: 64)]
        [JsonProperty("cashier")]
        public string Cashier { get; set; }

        /// <summary>
        /// ИНН кассира.
        /// </summary>
        [StringLength(maximumLength: 12)]
        [JsonProperty("cashier_inn")]
        public string CashierINN { get; set; }

        /// <summary>
        /// Дополнительный реквизит чека
        /// </summary>
        [StringLength(maximumLength: 16)]
        [JsonProperty("additional_check_props")]
        public string AdditionalCheckProps { get; set; }

        /// <summary>
        /// Итоговая сумма чека в рублях с заданным в CMS округлением:<br />
        /// ㅤ*целая часть не более 8 знаков;<br />
        /// ㅤ*дробная часть не более 2 знаков.<br />
        /// Значение вычисляется, как сумма всех значений реквизита «стоимость предмета расчета с учетом скидок и наценок»
        /// </summary>
        [JsonProperty("total")]
        public decimal Total { get; set; }

        /// <summary>
        /// Дополнительный реквизит пользователя.
        /// </summary>
        [JsonProperty("additional_user_props")]
        public AdditionalUserProps AdditionalUserProps { get; set; }

        /// <summary>
        /// Условия применения и значение реквизита «операционный реквизит чека»  определяются ФНС России.
        /// </summary>
        [JsonProperty("operating_check_props")]
        public OperatingCheckProps OperatingCheckProps { get; set; }

        /// <summary>
        /// Включается в состав кассового чека (БСО) в случае, если включение этого 
        /// отраслевого реквизита кассового чека предусмотрено законодательством Российской Федерации.
        /// </summary>
        [JsonProperty("sectoral_check_props")]
        public SectoralCheckProps SectoralCheckProps { get; set; }
    }
}
