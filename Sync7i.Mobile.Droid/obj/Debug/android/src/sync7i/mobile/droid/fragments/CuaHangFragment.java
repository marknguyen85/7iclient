package sync7i.mobile.droid.fragments;


public class CuaHangFragment
	extends md5d72a75edb579713d98da10c23665042d.BaseNestedView_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Sync7i.Mobile.Droid.Fragments.CuaHangFragment, 7i Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CuaHangFragment.class, __md_methods);
	}


	public CuaHangFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CuaHangFragment.class)
			mono.android.TypeManager.Activate ("Sync7i.Mobile.Droid.Fragments.CuaHangFragment, 7i Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
