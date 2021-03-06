/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: ComLocationStore.cs 				   	     
File Description 	: ComLocationStore is the corresponding data object to tblComLocationStore data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class ComLocationStore :BaseJsonEntity<ComLocationStore>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblComLocationStore="tblComLocationStore";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_StoreName="StoreName";
		public const string FIELD_SystemAccount="SystemAccount";
		public const string FIELD_IsCenter="IsCenter";
		public const string FIELD_GroupStoreID="GroupStoreID";
		public const string FIELD_IpClient="IpClient";
		public const string FIELD_StoreAddress="StoreAddress";
		public const string FIELD_IsDeleted="IsDeleted";
		public const string FIELD_CreatedBy="CreatedBy";
		public const string FIELD_CreatedAt="CreatedAt";
		public const string FIELD_ModifiedBy="ModifiedBy";
		public const string FIELD_ModifiedAt="ModifiedAt";
		#endregion
		
#region Members
protected int iD;
protected string storeName;
protected string systemAccount;
protected bool isCenter;
protected int groupStoreID;
protected string ipClient;
protected string storeAddress;
protected bool isDeleted;
protected string createdBy;
protected DateTime createdAt;
protected string modifiedBy;
protected DateTime modifiedAt;
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
/// Property relating to database column StoreName(nvarchar(500),not null)
/// </summary>
public string StoreName
{
	get { return storeName; }
	set { storeName = value; }
}

/// <summary>
/// Property relating to database column SystemAccount(nvarchar(1000),not null)
/// </summary>
public string SystemAccount
{
	get { return systemAccount; }
	set { systemAccount = value; }
}

/// <summary>
/// Property relating to database column IsCenter(bit,not null)
/// </summary>
public bool IsCenter
{
	get { return isCenter; }
	set { isCenter = value; }
}

/// <summary>
/// Property relating to database column GroupStoreID(int,not null)
/// </summary>
public int GroupStoreID
{
	get { return groupStoreID; }
	set { groupStoreID = value; }
}
public virtual ComGroupStore ComGroupStore{get;set;}

/// <summary>
/// Property relating to database column IpClient(varchar(50),null)
/// </summary>
public string IpClient
{
	get { return ipClient; }
	set { ipClient = value; }
}

/// <summary>
/// Property relating to database column StoreAddress(nvarchar(1000),not null)
/// </summary>
public string StoreAddress
{
	get { return storeAddress; }
	set { storeAddress = value; }
}

/// <summary>
/// Property relating to database column IsDeleted(bit,not null)
/// </summary>
public bool IsDeleted
{
	get { return isDeleted; }
	set { isDeleted = value; }
}

/// <summary>
/// Property relating to database column CreatedBy(nvarchar(100),not null)
/// </summary>
public string CreatedBy
{
	get { return createdBy; }
	set { createdBy = value; }
}

/// <summary>
/// Property relating to database column CreatedAt(datetime,not null)
/// </summary>
public DateTime CreatedAt
{
	get { return createdAt; }
	set { createdAt = value; }
}

/// <summary>
/// Property relating to database column ModifiedBy(nvarchar(100),not null)
/// </summary>
public string ModifiedBy
{
	get { return modifiedBy; }
	set { modifiedBy = value; }
}

/// <summary>
/// Property relating to database column ModifiedAt(datetime,not null)
/// </summary>
public DateTime ModifiedAt
{
	get { return modifiedAt; }
	set { modifiedAt = value; }
}
#endregion
		
     }
}
