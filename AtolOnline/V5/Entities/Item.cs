using AtolOnline.V5.Enums;
using Newtonsoft.Json;
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
        /// ㅤㅤ*целая часть не более 8 знаков<br />
        /// ㅤㅤ*дробная часть не более 2 знаков
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
    }
}
