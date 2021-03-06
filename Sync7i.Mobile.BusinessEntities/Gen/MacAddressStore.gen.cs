/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: MacAddressStore.cs 				   	     
File Description 	: MacAddressStore is the corresponding data object to tblMacAddressStore data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class MacAddressStore :BaseJsonEntity<MacAddressStore>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblMacAddressStore="tblMacAddressStore";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_MacAddress="MacAddress";
		#endregion
		
#region Members
protected int iD;
protected int locationStoreID;
protected string macAddress;
#endregion
#region Public Properties

/// <summary>
/// Property relating to database column ID(int,not null)
/// </summary>
public int ID
{
	get { return iD; }
	set { iD = value; }
}

/// <summary>
/// Property relating to database column LocationStoreID(int,not null)
/// </summary>
public int LocationStoreID
{
	get { return locationStoreID; }
	set { locationStoreID = value; }
}
public virtual ComLocationStore ComLocationStore{get;set;}

/// <summary>
/// Property relating to database column MacAddress(varchar(50),not null)
/// </summary>
public string MacAddress
{
	get { return macAddress; }
	set { macAddress = value; }
}
#endregion
		
     }
}
