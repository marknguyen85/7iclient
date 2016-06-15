using Sync7i.Mobile.Common;
using Sync7i.Mobile.Share;
using System.IO;
//using SQLite.Net.Interop;

namespace Sync7i.Mobile.Droid
{ 
    public class Droidlatform : IPlatform
    {
        const string sqliteFilename = "Database.db3";
        public TargetPlatform OS { get { return TargetPlatform.Android; } }
        public string DatabasePath
        {
            get
            {
                string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
                return Path.Combine(documentsPath, sqliteFilename);
            }
        }

        //public ISQLitePlatform SqlitePlatform
        //{
        //    get { return new SQLite.Net.Platform.WindowsPhone8.SQLitePlatformWP8(); }
        //}
    }
}

