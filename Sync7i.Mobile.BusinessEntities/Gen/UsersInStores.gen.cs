/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: UsersInStores.cs 				   	     
File Description 	: UsersInStores is the corresponding data object to tblUsersInStores data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class UsersInStores :BaseJsonEntity<UsersInStores>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblUsersInStores="tblUsersInStores";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_StoreID="StoreID";
		public const string FIELD_UserName="UserName";
		#endregion
		
#region Members
protected int iD;
protected int storeID;
protected string userName;
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
/// Property relating to database column StoreID(int,not null)
/// </summary>
public int StoreID
{
	get { return storeID; }
	set { storeID = value; }
}
public virtual ComLocationStore ComLocationStore{get;set;}

/// <summary>
/// Property relating to database column UserName(nvarchar(50),not null)
/// </summary>
public string UserName
{
	get { return userName; }
	set { userName = value; }
}
#endregion
		
     }
}
