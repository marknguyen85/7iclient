/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: MacAddressDevices.cs 				   	     
File Description 	: MacAddressDevices is the corresponding data object to tblMacAddressDevices data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class MacAddressDevices :BaseJsonEntity<MacAddressDevices>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblMacAddressDevices="tblMacAddressDevices";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_UDDI="UDDI";
		public const string FIELD_ComID="ComID";
		#endregion
		
#region Members
protected int iD;
protected string uDDI;
protected int comID;
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
/// Property relating to database column UDDI(varchar(500),not null)
/// </summary>
public string UDDI
{
	get { return uDDI; }
	set { uDDI = value; }
}

/// <summary>
/// Property relating to database column ComID(int,null)
/// </summary>
public int ComID
{
	get { return comID; }
	set { comID = value; }
}
public virtual Companies Companies{get;set;}
#endregion
		
     }
}
