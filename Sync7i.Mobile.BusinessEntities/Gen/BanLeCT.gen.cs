/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: BanLeCT.cs 				   	     
File Description 	: BanLeCT is the corresponding data object to tblBanLeCT data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class BanLeCT :BaseJsonEntity<BanLeCT>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblBanLeCT="tblBanLeCT";
		#region Column Names
		
		public const string FIELD_OnID="OnID";
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_BanLeID="BanLeID";
		public const string FIELD_SKU="SKU";
		public const string FIELD_SLBan="SLBan";
		public const string FIELD_DonGia="DonGia";
		public const string FIELD_GiamGia="GiamGia";
		public const string FIELD_ThanhTien="ThanhTien";
		public const string FIELD_VAT="VAT";
		public const string FIELD_TienVAT="TienVAT";
		public const string FIELD_CKPhanBo="CKPhanBo";
		public const string FIELD_GiaBan="GiaBan";
		public const string FIELD_GhiChuCT="GhiChuCT";
		public const string FIELD_CSKhuyenMai="CSKhuyenMai";
		#endregion
		
#region Members
protected long onID;
protected int locationStoreID;
protected int banLeID;
protected string sKU;
protected long sLBan;
protected decimal donGia;
protected decimal giamGia;
protected decimal thanhTien;
protected int vAT;
protected decimal tienVAT;
protected decimal cKPhanBo;
protected decimal giaBan;
protected string ghiChuCT;
protected string cSKhuyenMai;
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
/// Property relating to database column SKU(varchar(20),not null)
/// </summary>
public string SKU
{
	get { return sKU; }
	set { sKU = value; }
}

/// <summary>
/// Property relating to database column SLBan(bigint,null)
/// </summary>
public long SLBan
{
	get { return sLBan; }
	set { sLBan = value; }
}

/// <summary>
/// Property relating to database column DonGia(money,not null)
/// </summary>
public decimal DonGia
{
	get { return donGia; }
	set { donGia = value; }
}

/// <summary>
/// Property relating to database column GiamGia(money,null)
/// </summary>
public decimal GiamGia
{
	get { return giamGia; }
	set { giamGia = value; }
}

/// <summary>
/// Property relating to database column ThanhTien(money,not null)
/// </summary>
public decimal ThanhTien
{
	get { return thanhTien; }
	set { thanhTien = value; }
}

/// <summary>
/// Property relating to database column VAT(int,null)
/// </summary>
public int VAT
{
	get { return vAT; }
	set { vAT = value; }
}

/// <summary>
/// Property relating to database column TienVAT(money,null)
/// </summary>
public decimal TienVAT
{
	get { return tienVAT; }
	set { tienVAT = value; }
}

/// <summary>
/// Property relating to database column CKPhanBo(money,not null)
/// </summary>
public decimal CKPhanBo
{
	get { return cKPhanBo; }
	set { cKPhanBo = value; }
}

/// <summary>
/// Property relating to database column GiaBan(money,not null)
/// </summary>
public decimal GiaBan
{
	get { return giaBan; }
	set { giaBan = value; }
}

/// <summary>
/// Property relating to database column GhiChuCT(nvarchar(50),null)
/// </summary>
public string GhiChuCT
{
	get { return ghiChuCT; }
	set { ghiChuCT = value; }
}

/// <summary>
/// Property relating to database column CSKhuyenMai(nvarchar(20),null)
/// </summary>
public string CSKhuyenMai
{
	get { return cSKhuyenMai; }
	set { cSKhuyenMai = value; }
}
#endregion
		
     }
}
