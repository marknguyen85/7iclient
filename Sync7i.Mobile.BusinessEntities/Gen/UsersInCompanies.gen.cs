/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: UsersInCompanies.cs 				   	     
File Description 	: UsersInCompanies is the corresponding data object to tblUsersInCompanies data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class UsersInCompanies :BaseJsonEntity<UsersInCompanies>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblUsersInCompanies="tblUsersInCompanies";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_ComID="ComID";
		public const string FIELD_UserName="UserName";
		#endregion
		
#region Members
protected int iD;
protected int comID;
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
/// Property relating to database column ComID(int,not null)
/// </summary>
public int ComID
{
	get { return comID; }
	set { comID = value; }
}
public virtual Companies Companies{get;set;}

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
