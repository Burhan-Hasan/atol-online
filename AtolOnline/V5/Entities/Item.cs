using AtolOnline.V5.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtolOnline.V5.Entities
{
    public class Item
    {
        /// <summary>
        /// Наименование товара, работы, услуги, платежа, выплаты, иного предмета расчета.
        /// </summary>
        [JsonProperty("name")]
        [StringLength(maximumLength: 128)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Цена за единицу товара, работы, услуги, платежа, выплаты, иного предмета расчета с учетом скидок и наценок
        /// <para>Цена в рублях:</para>
        /// <para>* целая часть не более 8 знаков</para>
        /// <para>* дробная часть не более 2 знаков</para>
        /// <para>Максимальное значение цены – 42 949 672.95.</para>
        /// <para>При этом произведение цены и количество/веса (price*quantity) позиции должно быть не больше максимального значения цены позиции.</para>
        /// </summary>
        [JsonProperty("price")]
        [Required]
        public decimal Price { get; set; }


        /// <summary>
        /// Количество/вес:
        /// <para>целая часть не более 5 знаков</para>
        /// <para>дробная часть не более 3 знаков</para>
        /// <para>Максимальное значение – 99 999.999</para>
        /// <para>В случае, если предметом расчета является товар, подлежащий обязательной маркировке средством идентификации (передан mark_code), параметр должен принимать значение, равное «1».</para>
        /// </summary>
        [JsonProperty("quantity")]
        [Required]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Единицы измерения количества предмета расчета/
        /// </summary>
        [JsonProperty("measure")]
        [Required]
        public Measurement Measure { get; set; }

        /// <summary>
        /// Сумма в рублях:<br />
        /// ㅤ*целая часть не более 8 знаков<br />
        /// ㅤ*дробная часть не более 2 знаков
        /// <para>Максимальное значение – 42 949 672.95.</para>
        /// <para>Значение реквизита «стоимость предмета расчета с учетом скидок и наценок» 
        /// (тег 1043) должно быть равно произведению 
        /// значения реквизита «цена за единицу предмета расчета с учетом скидок и наценок» 
        /// (тег 1079), умноженному на значение реквизита «количество предмета расчета» (тег 1023).
        /// </para>
        /// </summary>
        [JsonProperty("sum")]
        [Required]
        public decimal Sum { get; set; }

        /// <summary>
        /// <para>Признак способа расчёта.</para>
        /// <para>Enum -> PaymentMethods</para>
        /// </summary>
        [JsonProperty("payment_method")]
        [Required]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// <para>Признак предмета расчёта:</para>
        /// <para>
        /// 1 - о реализуемом товаре, за исключением подакцизного товара и товара, подлежащего маркировке 
        /// средствами идентификации (наименование и иные сведения, описывающие товар)
        /// </para>
        /// <para>
        /// 2 - о реализуемом подакцизном товаре, за исключением товара, 
        /// подлежащего маркировке средствами идентификации 
        /// (наименование и иные сведения, описывающие товар)
        /// </para>
        /// <br />
        /// Стр 27 <see href="https://online.atol.ru/files/API_atol_online_v5.pdf" />
        /// </summary>
        [JsonProperty("payment_object")]
        [Required]
        public int PaymentObject { get; set; }

        /// <summary>
        /// Атрибуты налога на позицию.
        /// </summary>
        [Required]
        public Vat Vat { get; set; }

        /// <summary>
        /// Дополнительный реквизит предмета расчета.
        /// </summary>
        [JsonProperty("user_data")]
        [StringLength(maximumLength: 64)]
        public string UserData { get; set; }

        /// <summary>
        /// Сумма акциза в рублях<br />
        /// целая часть не более 8 знаков<br />
        /// дробная часть не более 2 знаков<br />
        /// значение не может быть отрицательным
        /// </summary>
        [JsonProperty("excise")]
        public decimal Excise { get; set; }

        /// <summary>
        /// Цифровой код страны происхождения товара ровно 3 цифры
        /// Код страны указывается в соответствии с Общероссийским классификатором стран мира ОКСМ. 
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }


        /// <summary>
        /// Номер таможенной декларации
        /// </summary>
        [JsonProperty("declaration_number")]
        [StringLength(maximumLength: 32)]
        public string DeclarationNumber { get; set; }

        /// <summary>
        /// Реквизит «дробное количество маркированного товара»
        /// </summary>
        public MarkQuantity MarkQuantity { get; set; }

        /// <summary>
        /// Включается в чек в случае, если предметом расчета является товар, 
        /// подлежащий обязательной маркировке средством идентификации. Должен принимать значение равное «0»
        /// </summary>
        [JsonProperty("mark_processing_mode")]
        public string MarkProcessingMode { get; set; }

        //TODO: Not implemented yet
        [JsonProperty("sectoral_item_props")]
        public List<object> SectoralItemProps { get; set; }

        [JsonProperty("mark_code")]
        public MarkCode MarkCode { get; set; }

        /// <summary>
        /// Атрибуты агента.
        /// </summary>
        [JsonProperty("agent_info")]
        //TODO: Not implemented yet
        public object AgentInfo { get; set; }


        /// <summary>
        /// Атрибуты поставщика.
        /// Поле обязательно, если передан «agent_info».
        /// </summary>
        [JsonProperty("supplier_info")]
        //TODO: Not implemented yet
        public object SupplierInfo { get; set; }
    }
}
