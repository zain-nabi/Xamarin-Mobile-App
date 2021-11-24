using Mad_Dog.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Dog.Service
{
    public class UserService
    {
        private string url = "https://localhost:44374/api/";
        public static async Task<List<NewFolder.Users>> GetAllStatements()
        {
            return await RestApiHelper.GetAsync<List<NewFolder.Users>>(new Uri(UrlHelper.Api.UserUrl, $"User/GetUsers"));
        }

        public static async Task<bool> InsertAsync(NewFolder.Users model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.UserUrl, $"User/InsertAsync/Insert"), model);
        }

        public static async Task<bool> UpdateAsync(NewFolder.Users model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.UserUrl, $"User/UpdateAsync/Update"), model);
        }

        public static async Task<bool> DeleteAsync(NewFolder.Users model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.UserUrl, $"User/DeleteAsync/Update"), model);
        }
    }
}
