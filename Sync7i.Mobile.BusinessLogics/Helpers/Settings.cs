// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessLogics.Helpers
{
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		private const string UGTokenKey = "UGTokenKey";
		private const string SaltKey = "SaltKey";
		private const string ListStoresKey = "ListStoresKey";
		private const string UserNameKey = "UserNameKey";
		private const string PasswordKey = "PasswordKey";
		private static readonly string SettingsDefault = string.Empty;

		#endregion
		public static string UserName
		{
			get
			{
				return AppSettings.GetValueOrDefault(UserNameKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(UserNameKey, value);
			}
		}
		public static string Password
		{
			get
			{
				var cipherText = AppSettings.GetValueOrDefault(PasswordKey, SettingsDefault);

				if (string.IsNullOrWhiteSpace(cipherText) || string.IsNullOrWhiteSpace(Salt))
					return string.Empty;

				return AESEngine.Decryption(cipherText, Salt);
			}
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					if (string.IsNullOrWhiteSpace(Salt))
						Salt = AESEngine.CreateSalt();

					var text = AESEngine.Encryption(value, Salt);

					AppSettings.AddOrUpdateValue(PasswordKey, text);
				}
				else AppSettings.AddOrUpdateValue(PasswordKey, value);
			}
		}
		private static string Salt
		{
			get
			{
				return AppSettings.GetValueOrDefault(SaltKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SaltKey, value);
			}
		}
		public static string UGToken
		{
			get
			{
				var cipherText = AppSettings.GetValueOrDefault(UGTokenKey, SettingsDefault);

				if (string.IsNullOrWhiteSpace(cipherText) || string.IsNullOrWhiteSpace(Salt))
					return string.Empty;

				return AESEngine.Decryption(cipherText, Salt);
			}
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					if (string.IsNullOrWhiteSpace(Salt))
						Salt = AESEngine.CreateSalt();

					var text = AESEngine.Encryption(value, Salt);

					AppSettings.AddOrUpdateValue(UGTokenKey, text);
				}
				else AppSettings.AddOrUpdateValue(UGTokenKey, value);
			}
		}
		public static string ListStores
		{
			get
			{
				return AppSettings.GetValueOrDefault(ListStoresKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(ListStoresKey, value);
			}
		}
	}
}