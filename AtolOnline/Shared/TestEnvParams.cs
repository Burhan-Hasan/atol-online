using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.Shared
{
    //АТОЛ Онлайн версии 4 (v4), поддерживают формат фискальных документов версии 1.05.
    public class TestEnvParamsV4
    {
        public static readonly string Endpoint = "https://testonline.atol.ru/possystem/v4/";
        public static readonly string PaymentAddress = "https://v4.online.atol.ru";
        public static readonly string CompanyName = "АТОЛ";
        public static readonly string INN = "5544332219";
        public static readonly string Group = "v4-online-atol-ru_4179";
        public static readonly string Login = "v4-online-atol-ru";
        public static readonly string Password = "iGFFuihss";

        //Проверка чека в Первый ОФД
        //https://consumer.1-ofd-test.ru/v1?fn=9999078902010421&fp=2680485228&i=1545
        //где
        //fn = Номер ФН - "fn_number"
        //fp=ФПД - "fiscal_document_attribute"
        //i=Номер ФД - "fiscal_document_number"
        public static readonly string EndpointOFD = "https://consumer.1-ofd-test.ru/v1";
    }

    //АТОЛ Онлайн версии 5 (v5), поддерживают формат фискальных документов версии 1.2.
    public class TestEnvParamsV5
    {
        public static readonly string Endpoint = "https://testonline.atol.ru/possystem/v5/";
        public static readonly string PaymentAddress = "https://v5.online.atol.ru";

        public static readonly string CompanyName = "АТОЛ";
        public static readonly string INN = "5544332219";
        public static readonly string Group = "v5-online-atol-ru_5179";
        public static readonly string Login = "v5-online-atol-ru";
        public static readonly string Password = "zUr0OxfI";
    }
}
