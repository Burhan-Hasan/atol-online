using AtolOnline.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.V5.Client
{
    public class AtolClient
    {
        private readonly string login;
        private readonly string password;

        //Флаг тестового режима
        bool IsTestMode { get; set; }

        //Логин доступа к API
        string Login => IsTestMode ? TestEnvParamsV5.Login : login;
        //Пароль доступа к API
        string Password => password;
        //Токен авторизации
        public string Token { get; set; }

        /// <param name="testMode">Флаг тестового режима</param>
        /// <param name="login">Логин доступа к API</param>
        /// <param name="pass">Пароль доступа к API</param>
        public AtolClient(bool testMode, string atol_login, string atol_password)
        {
            IsTestMode = testMode;
            login = atol_login;
            password = atol_password;

            if (!testMode)
            {
                if (string.IsNullOrEmpty(atol_login)) throw new Exception("Логин не может быть пустым");
                if (string.IsNullOrEmpty(atol_password)) throw new Exception("Пароль не может быть пустым");
            }
        }
    }
}
