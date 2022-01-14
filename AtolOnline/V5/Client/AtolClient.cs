using System;
using System.Collections.Generic;
using System.Text;

namespace AtolOnline.V5.Client
{
    public class AtolClient
    {
        //Флаг тестового режима
        bool IsTestMode { get; set; }

        //Логин доступа к API
        string Login { get; }

        //Пароль доступа к API
        string Password { get; }

        //Токен авторизации
        public string Token { get; set; }

        /// <param name="testMode">Флаг тестового режима</param>
        /// <param name="login">Логин доступа к API</param>
        /// <param name="pass">Пароль доступа к API</param>
        public AtolClient(bool testMode, string login, string pass) => (IsTestMode, Login, Password) = (testMode, login, pass);
    }
}
