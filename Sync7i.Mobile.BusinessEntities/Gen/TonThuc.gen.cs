/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: TonThuc.cs 				   	     
File Description 	: TonThuc is the corresponding data object to tblTonThuc data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class TonThuc :BaseJsonEntity<TonThuc>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblTonThuc="tblTonThuc";
		#region Column Names
		
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_ID="ID";
		public const string FIELD_Ngay="Ngay";
		public const string FIELD_SoTiem="SoTiem";
		public const string FIELD_NguoiNhap="NguoiNhap";
		public const string FIELD_SyncDate="SyncDate";
		public const string FIELD_ItemVersion="ItemVersion";
		#endregion
		
#region Members
protected int locationStoreID;
protected int iD;
protected DateTime ngay;
protected decimal soTiem;
protected string nguoiNhap;
protected DateTime syncDate;
protected int itemVersion;
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
/// Property relating to database column ID(int,not null)
/// </summary>
public int ID
{
	get { return iD; }
	set { iD = value; }
}

/// <summary>
/// Property relating to database column Ngay(date,not null)
/// </summary>
public DateTime Ngay
{
	get { return ngay; }
	set { ngay = value; }
}

/// <summary>
/// Property relating to database column SoTiem(money,not null)
/// </summary>
public decimal SoTiem
{
	get { return soTiem; }
	set { soTiem = value; }
}

/// <summary>
/// Property relating to database column NguoiNhap(nvarchar(200),not null)
/// </summary>
public string NguoiNhap
{
	get { return nguoiNhap; }
	set { nguoiNhap = value; }
}

/// <summary>
/// Property relating to database column SyncDate(datetime,not null)
/// </summary>
public DateTime SyncDate
{
	get { return syncDate; }
	set { syncDate = value; }
}

/// <summary>
/// Property relating to database column ItemVersion(int,null)
/// </summary>
public int ItemVersion
{
	get { return itemVersion; }
	set { itemVersion = value; }
}
#endregion
		
     }
}
