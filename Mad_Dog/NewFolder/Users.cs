using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mad_Dog.NewFolder
{
    public class Users
    {
        [JsonProperty("UserID")]
        public int UserID { get; set; }
        [JsonProperty("Username")]
        public string Username { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Cell")]
        public string Cell { get; set; }
    }
}
