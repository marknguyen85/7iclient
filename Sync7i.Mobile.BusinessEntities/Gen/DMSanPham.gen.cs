/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: DMSanPham.cs 				   	     
File Description 	: DMSanPham is the corresponding data object to tblDMSanPham data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class DMSanPham :BaseJsonEntity<DMSanPham>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblDMSanPham="tblDMSanPham";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_SKU="SKU";
		public const string FIELD_Ten="Ten";
		public const string FIELD_QuyCach="QuyCach";
		public const string FIELD_DVT="DVT";
		public const string FIELD_MaNganhHang="MaNganhHang";
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_SyncDate="SyncDate";
		public const string FIELD_BarCode="BarCode";
		#endregion
		
#region Members
protected int iD;
protected string sKU;
protected string ten;
protected int quyCach;
protected string dVT;
protected int maNganhHang;
protected int locationStoreID;
protected DateTime syncDate;
protected string barCode;
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
/// Property relating to database column SKU(varchar(20),not null)
/// </summary>
public string SKU
{
	get { return sKU; }
	set { sKU = value; }
}

/// <summary>
/// Property relating to database column Ten(nvarchar(100),not null)
/// </summary>
public string Ten
{
	get { return ten; }
	set { ten = value; }
}

/// <summary>
/// Property relating to database column QuyCach(int,not null)
/// </summary>
public int QuyCach
{
	get { return quyCach; }
	set { quyCach = value; }
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
/// Property relating to database column MaNganhHang(int,not null)
/// </summary>
public int MaNganhHang
{
	get { return maNganhHang; }
	set { maNganhHang = value; }
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
/// Property relating to database column SyncDate(datetime,not null)
/// </summary>
public DateTime SyncDate
{
	get { return syncDate; }
	set { syncDate = value; }
}

/// <summary>
/// Property relating to database column BarCode(varchar(20),null)
/// </summary>
public string BarCode
{
	get { return barCode; }
	set { barCode = value; }
}
#endregion
		
     }
}
