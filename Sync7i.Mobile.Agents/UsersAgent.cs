using Newtonsoft.Json;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.Agents
{
    public partial class UsersAgent : AgentBase<UsersAgent>
    {
        //api/users/Authenticate
        private readonly string ResourceAuthe = "api/users/Authenticate";
        public async Task<UserAuthenStatus> Authenticate(UserAuthen user)
        {
            var data = SetDataJson(user);
            var response = new HttpResponseMessage();
            //try
            //{
                response = await HTTPClient.PostAsync(ResourceAuthe, new StringContent(data, Encoding.UTF8, ContentType));
            //}
            //catch (HttpRequestException ex)
            //{
            //    throw new HTTPException(System.Net.HttpStatusCode.Unauthorized, ex.Message);
            //}
            if (response.IsSuccessStatusCode)
            {
                string contentStr = await response.Content.ReadAsStringAsync();

                var responseContent = await GetDataJson<UserAuthenStatus>(contentStr);

                if (!responseContent.Successeded)
                    throw new BusinessException(ErrorCode.Business, responseContent.Message);

                return responseContent;
            }
            else
            {
                throw new UnknownException(response.StatusCode.ToString());
            }
        }
    }
}
