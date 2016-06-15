using Sync7i.Mobile.Common;
using System;

namespace Sync7i.Mobile.Share
{
    public interface IPlatform
    {
        TargetPlatform OS { get; }

        string DatabasePath { get; }

        //TODO: Step 2b - Add ISQLitePlatform to IPlatform.
        //ISQLitePlatform SqlitePlatform { get; }
    }
}

