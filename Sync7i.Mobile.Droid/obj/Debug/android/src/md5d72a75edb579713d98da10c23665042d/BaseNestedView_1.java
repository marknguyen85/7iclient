package md5d72a75edb579713d98da10c23665042d;


public abstract class BaseNestedView_1
	extends md5d72a75edb579713d98da10c23665042d.BaseNestedView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Sync7i.Mobile.Droid.BaseNestedView`1, 7i Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseNestedView_1.class, __md_methods);
	}


	public BaseNestedView_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaseNestedView_1.class)
			mono.android.TypeManager.Activate ("Sync7i.Mobile.Droid.BaseNestedView`1, 7i Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
