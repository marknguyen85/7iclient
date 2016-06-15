using System;
using System.Collections.Generic;
using System.Linq;

namespace Sync7i.Mobile.BusinessEntities
{
    public class UserAuthen
    {
        public UserAuthen()
        {
        }
        public UserAuthen(string userId, string password)
        {
            UserId = userId;
            Password = password;
        }
        public UserAuthen(string userId, string password, string macAddress, int expireTimeSpanHours)
        {
            UserId = userId;
            Password = password;
            MacAddress = macAddress;
            ExpireTimeSpanHours = expireTimeSpanHours;
        }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string MacAddress { get; set; }
        public int ExpireTimeSpanHours { get; set; }
    }
}
