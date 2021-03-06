/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: DMSanPhamPrice.cs 				   	     
File Description 	: DMSanPhamPrice is the corresponding data object to tblDMSanPhamPrice data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class DMSanPhamPrice :BaseJsonEntity<DMSanPhamPrice>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblDMSanPhamPrice="tblDMSanPhamPrice";
		#region Column Names
		
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_SKU="SKU";
		public const string FIELD_DVT="DVT";
		public const string FIELD_GiaLe="GiaLe";
		public const string FIELD_SyncDate="SyncDate";
		#endregion
		
#region Members
protected int locationStoreID;
protected string sKU;
protected string dVT;
protected decimal giaLe;
protected DateTime syncDate;
#endregion
#region Public Properties

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
/// Property relating to database column SKU(varchar(20),not null)
/// </summary>
public string SKU
{
	get { return sKU; }
	set { sKU = value; }
}

/// <summary>
/// Property relating to database column DVT(nvarchar(20),not null)
/// </summary>
public string DVT
{
	get { return dVT; }
	set { dVT = value; }
}

/// <summary>
/// Property relating to database column GiaLe(money,not null)
/// </summary>
public decimal GiaLe
{
	get { return giaLe; }
	set { giaLe = value; }
}

/// <summary>
/// Property relating to database column SyncDate(datetime,not null)
/// </summary>
public DateTime SyncDate
{
	get { return syncDate; }
	set { syncDate = value; }
}
#endregion
		
     }
}
