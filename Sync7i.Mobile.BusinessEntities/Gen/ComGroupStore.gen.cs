/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: ComGroupStore.cs 				   	     
File Description 	: ComGroupStore is the corresponding data object to tblComGroupStore data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class ComGroupStore :BaseJsonEntity<ComGroupStore>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblComGroupStore="tblComGroupStore";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_GroupName="GroupName";
		public const string FIELD_CompanyID="CompanyID";
		#endregion
		
#region Members
protected int iD;
protected string groupName;
protected int companyID;
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
/// Property relating to database column GroupName(nvarchar(50),not null)
/// </summary>
public string GroupName
{
	get { return groupName; }
	set { groupName = value; }
}

/// <summary>
/// Property relating to database column CompanyID(int,not null)
/// </summary>
public int CompanyID
{
	get { return companyID; }
	set { companyID = value; }
}
public virtual Companies Companies{get;set;}
#endregion
		
     }
}
