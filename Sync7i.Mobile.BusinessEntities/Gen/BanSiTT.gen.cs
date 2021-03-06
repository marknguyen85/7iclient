/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: BanSiTT.cs 				   	     
File Description 	: BanSiTT is the corresponding data object to tblBanSiTT data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class BanSiTT :BaseJsonEntity<BanSiTT>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblBanSiTT="tblBanSiTT";
		#region Column Names
		
		public const string FIELD_OnID="OnID";
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_BanLeID="BanLeID";
		public const string FIELD_Ngay="Ngay";
		public const string FIELD_CongNo="CongNo";
		public const string FIELD_ThanhToan="ThanhToan";
		public const string FIELD_GhiChu="GhiChu";
		#endregion
		
#region Members
protected long onID;
protected int locationStoreID;
protected int banLeID;
protected DateTime ngay;
protected decimal congNo;
protected decimal thanhToan;
protected string ghiChu;
#endregion
#region Public Properties

/// <summary>
/// Property relating to database column OnID(bigint,not null)
/// </summary>
public long OnID
{
	get { return onID; }
	set { onID = value; }
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
/// Property relating to database column BanLeID(int,not null)
/// </summary>
public int BanLeID
{
	get { return banLeID; }
	set { banLeID = value; }
}
public virtual BanLe BanLe{get;set;}

/// <summary>
/// Property relating to database column Ngay(date,not null)
/// </summary>
public DateTime Ngay
{
	get { return ngay; }
	set { ngay = value; }
}

/// <summary>
/// Property relating to database column CongNo(money,not null)
/// </summary>
public decimal CongNo
{
	get { return congNo; }
	set { congNo = value; }
}

/// <summary>
/// Property relating to database column ThanhToan(money,not null)
/// </summary>
public decimal ThanhToan
{
	get { return thanhToan; }
	set { thanhToan = value; }
}

/// <summary>
/// Property relating to database column GhiChu(nvarchar(200),null)
/// </summary>
public string GhiChu
{
	get { return ghiChu; }
	set { ghiChu = value; }
}
#endregion
		
     }
}
