
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
namespace Sync7i.Mobile.Common
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumDescriptionAttribute : Attribute
    {
        private readonly string description;
        public string Description { get { return description; } }
        public EnumDescriptionAttribute(string description)
        {
            this.description = description;
        }
    }
    public static class EnumHelper
    {
        public static string GetDescription(object enumerator)
        {
            try
            {
                //get the enumerator type
                Type type = enumerator.GetType();

                //get the member info
                var memberInfo = type.GetRuntimeField(enumerator.ToString());

                //if there is member information
                if (memberInfo != null)
                {
                    //we default to the first member info, as it's for the specific enum value
                    var attribute = memberInfo.GetCustomAttribute<EnumDescriptionAttribute>();

                    //return the description if it's found
                    if (attribute != null)
                        return attribute.Description;
                }

                //if there's no description, return the string value of the enum
                return enumerator.ToString();
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
    
}