/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: TienMat.cs 				   	     
File Description 	: TienMat is the corresponding data object to tblTienMat data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class TienMat :BaseJsonEntity<TienMat>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblTienMat="tblTienMat";
		#region Column Names
		
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_ID="ID";
		public const string FIELD_Ngay="Ngay";
		public const string FIELD_NhanVien="NhanVien";
		public const string FIELD_TonDauN="TonDauN";
		public const string FIELD_BanHang="BanHang";
		public const string FIELD_TTTienHang="TTTienHang";
		public const string FIELD_ChiPhi="ChiPhi";
		public const string FIELD_TamUng="TamUng";
		public const string FIELD_ThuKhac="ThuKhac";
		public const string FIELD_TonCuoiN="TonCuoiN";
		public const string FIELD_TonThuc="TonThuc";
		public const string FIELD_Lech="Lech";
		public const string FIELD_KhoaSo="KhoaSo";
		public const string FIELD_CongNo="CongNo";
		#endregion
		
#region Members
protected int locationStoreID;
protected int iD;
protected DateTime ngay;
protected string nhanVien;
protected decimal tonDauN;
protected decimal banHang;
protected decimal tTTienHang;
protected decimal chiPhi;
protected decimal tamUng;
protected decimal thuKhac;
protected decimal tonCuoiN;
protected decimal tonThuc;
protected decimal lech;
protected bool khoaSo;
protected decimal congNo;
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
/// Property relating to database column Ngay(date,null)
/// </summary>
public DateTime Ngay
{
	get { return ngay; }
	set { ngay = value; }
}

/// <summary>
/// Property relating to database column NhanVien(nvarchar(50),null)
/// </summary>
public string NhanVien
{
	get { return nhanVien; }
	set { nhanVien = value; }
}

/// <summary>
/// Property relating to database column TonDauN(money,null)
/// </summary>
public decimal TonDauN
{
	get { return tonDauN; }
	set { tonDauN = value; }
}

/// <summary>
/// Property relating to database column BanHang(money,null)
/// </summary>
public decimal BanHang
{
	get { return banHang; }
	set { banHang = value; }
}

/// <summary>
/// Property relating to database column TTTienHang(money,null)
/// </summary>
public decimal TTTienHang
{
	get { return tTTienHang; }
	set { tTTienHang = value; }
}

/// <summary>
/// Property relating to database column ChiPhi(money,null)
/// </summary>
public decimal ChiPhi
{
	get { return chiPhi; }
	set { chiPhi = value; }
}

/// <summary>
/// Property relating to database column TamUng(money,null)
/// </summary>
public decimal TamUng
{
	get { return tamUng; }
	set { tamUng = value; }
}

/// <summary>
/// Property relating to database column ThuKhac(money,null)
/// </summary>
public decimal ThuKhac
{
	get { return thuKhac; }
	set { thuKhac = value; }
}

/// <summary>
/// Property relating to database column TonCuoiN(money,null)
/// </summary>
public decimal TonCuoiN
{
	get { return tonCuoiN; }
	set { tonCuoiN = value; }
}

/// <summary>
/// Property relating to database column TonThuc(money,null)
/// </summary>
public decimal TonThuc
{
	get { return tonThuc; }
	set { tonThuc = value; }
}

/// <summary>
/// Property relating to database column Lech(money,null)
/// </summary>
public decimal Lech
{
	get { return lech; }
	set { lech = value; }
}

/// <summary>
/// Property relating to database column KhoaSo(bit,null)
/// </summary>
public bool KhoaSo
{
	get { return khoaSo; }
	set { khoaSo = value; }
}

/// <summary>
/// Property relating to database column CongNo(money,null)
/// </summary>
public decimal CongNo
{
	get { return congNo; }
	set { congNo = value; }
}
#endregion
		
     }
}
