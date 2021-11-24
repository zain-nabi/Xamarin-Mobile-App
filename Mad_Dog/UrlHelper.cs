using System;
using System.Collections.Generic;
using System.Text;

namespace Mad_Dog
{
    public static class UrlHelper
    {
        public static class Api
        {
            public static Uri UserUrl => new Uri($"http://192.168.18.8:7002/api/");

        }

        public static class ApiControllers
        {
            public const string Users = "Users/";
        }

    }
}
