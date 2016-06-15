using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using Sync7i.Mobile.BusinessEntities;
using Sync7i.Mobile.Agents;
using Sync7i.Mobile.BusinessLogics.Helpers;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessLogics
{
    public class BaseBiz<T>
        where T : class, new()
    {
        static object obj = new object();
        private static T instance;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        instance = new T();
                    }
                }
                return instance;
            }
        }
    }
	public interface IUserBiz
	{
        Task<UserAuthenStatus> Authen(UserAuthen user);
        void ResetToken();
	}

	public class UserBiz :BaseBiz<UserBiz>, IUserBiz
	{
        public string UGToken
        {
            get
            {
                return Settings.UGToken;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Settings.UGToken = value;
                }
            }
        }
        public UserAuthen User
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Settings.UserName))
                    return null;
                var user = new UserAuthen(Settings.UserName, Settings.Password);
                return user;
            }
            set
            {
                if (value!=null)
                {
                    Settings.UserName=value.UserId;
                    Settings.Password = value.Password;
                }
            }
        }
        public List<int> ListStores
        {
            get
            {
                return Settings.ListStores.ToRoles();
            }
            set
            {
                if (value != null && value.Count>0)
                {
                    Settings.ListStores = value.ListToString();
                }
            }
        }
        public async Task<UserAuthenStatus> Authen(UserAuthen user)
        {
            User = user;
            var status = await AgentRepository.Instance.Users.Authenticate(user);
            UGToken = status.UGToken;
            ListStores = status.ListStores.Select(x=>x.ID).ToList();
            return status;
        }


        public void ResetToken()
        {
            Settings.UGToken = string.Empty;
        }
    }
}

