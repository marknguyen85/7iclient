/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: Companies.cs 				   	     
File Description 	: Companies is the corresponding data object to tblCompanies data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class Companies :BaseJsonEntity<Companies>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblCompanies="tblCompanies";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_MST="MST";
		public const string FIELD_TenDonVi="TenDonVi";
		public const string FIELD_DiaChi="DiaChi";
		public const string FIELD_SoDienThoai="SoDienThoai";
		public const string FIELD_Website="Website";
		public const string FIELD_Email="Email";
		public const string FIELD_LoiCamOn="LoiCamOn";
		public const string FIELD_BrandRetail="BrandRetail";
		public const string FIELD_WebConnectionString="WebConnectionString";
		public const string FIELD_MaCan="MaCan";
		public const string FIELD_NhapSL="NhapSL";
		public const string FIELD_CanhBaoSNKhachHang="CanhBaoSNKhachHang";
		public const string FIELD_QuyDoiDiemKhachHang="QuyDoiDiemKhachHang";
		public const string FIELD_KyKiemKhoType="KyKiemKhoType";
		public const string FIELD_DuLieuPhanTichTongNgay="DuLieuPhanTichTongNgay";
		public const string FIELD_DuLieuPhanTichTrungBinhNgay="DuLieuPhanTichTrungBinhNgay";
		public const string FIELD_IsDeleted="IsDeleted";
		public const string FIELD_CreatedBy="CreatedBy";
		public const string FIELD_CreatedAt="CreatedAt";
		public const string FIELD_ModifiedBy="ModifiedBy";
		public const string FIELD_ModifiedAt="ModifiedAt";
		#endregion
		
#region Members
protected int iD;
protected string mST;
protected string tenDonVi;
protected string diaChi;
protected string soDienThoai;
protected string website;
protected string email;
protected string loiCamOn;
protected string brandRetail;
protected string webConnectionString;
protected string maCan;
protected int nhapSL;
protected int canhBaoSNKhachHang;
protected decimal quyDoiDiemKhachHang;
protected int kyKiemKhoType;
protected int duLieuPhanTichTongNgay;
protected int duLieuPhanTichTrungBinhNgay;
protected bool isDeleted;
protected string createdBy;
protected DateTime createdAt;
protected string modifiedBy;
protected DateTime modifiedAt;
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
/// Property relating to database column MST(nvarchar(50),not null)
/// </summary>
public string MST
{
	get { return mST; }
	set { mST = value; }
}

/// <summary>
/// Property relating to database column TenDonVi(nvarchar(500),not null)
/// </summary>
public string TenDonVi
{
	get { return tenDonVi; }
	set { tenDonVi = value; }
}

/// <summary>
/// Property relating to database column DiaChi(nvarchar(1000),not null)
/// </summary>
public string DiaChi
{
	get { return diaChi; }
	set { diaChi = value; }
}

/// <summary>
/// Property relating to database column SoDienThoai(varchar(20),not null)
/// </summary>
public string SoDienThoai
{
	get { return soDienThoai; }
	set { soDienThoai = value; }
}

/// <summary>
/// Property relating to database column Website(nvarchar(200),null)
/// </summary>
public string Website
{
	get { return website; }
	set { website = value; }
}

/// <summary>
/// Property relating to database column Email(nvarchar(200),null)
/// </summary>
public string Email
{
	get { return email; }
	set { email = value; }
}

/// <summary>
/// Property relating to database column LoiCamOn(nvarchar(500),not null)
/// </summary>
public string LoiCamOn
{
	get { return loiCamOn; }
	set { loiCamOn = value; }
}

/// <summary>
/// Property relating to database column BrandRetail(nvarchar(50),not null)
/// </summary>
public string BrandRetail
{
	get { return brandRetail; }
	set { brandRetail = value; }
}

/// <summary>
/// Property relating to database column WebConnectionString(nvarchar(1000),null)
/// </summary>
public string WebConnectionString
{
	get { return webConnectionString; }
	set { webConnectionString = value; }
}

/// <summary>
/// Property relating to database column MaCan(varchar(5),null)
/// </summary>
public string MaCan
{
	get { return maCan; }
	set { maCan = value; }
}

/// <summary>
/// Property relating to database column NhapSL(int,null)
/// </summary>
public int NhapSL
{
	get { return nhapSL; }
	set { nhapSL = value; }
}

/// <summary>
/// Property relating to database column CanhBaoSNKhachHang(int,null)
/// </summary>
public int CanhBaoSNKhachHang
{
	get { return canhBaoSNKhachHang; }
	set { canhBaoSNKhachHang = value; }
}

/// <summary>
/// Property relating to database column QuyDoiDiemKhachHang(money,null)
/// </summary>
public decimal QuyDoiDiemKhachHang
{
	get { return quyDoiDiemKhachHang; }
	set { quyDoiDiemKhachHang = value; }
}

/// <summary>
/// Property relating to database column KyKiemKhoType(int,null)
/// </summary>
public int KyKiemKhoType
{
	get { return kyKiemKhoType; }
	set { kyKiemKhoType = value; }
}

/// <summary>
/// Property relating to database column DuLieuPhanTichTongNgay(int,null)
/// </summary>
public int DuLieuPhanTichTongNgay
{
	get { return duLieuPhanTichTongNgay; }
	set { duLieuPhanTichTongNgay = value; }
}

/// <summary>
/// Property relating to database column DuLieuPhanTichTrungBinhNgay(int,null)
/// </summary>
public int DuLieuPhanTichTrungBinhNgay
{
	get { return duLieuPhanTichTrungBinhNgay; }
	set { duLieuPhanTichTrungBinhNgay = value; }
}

/// <summary>
/// Property relating to database column IsDeleted(bit,not null)
/// </summary>
public bool IsDeleted
{
	get { return isDeleted; }
	set { isDeleted = value; }
}

/// <summary>
/// Property relating to database column CreatedBy(nvarchar(100),not null)
/// </summary>
public string CreatedBy
{
	get { return createdBy; }
	set { createdBy = value; }
}

/// <summary>
/// Property relating to database column CreatedAt(datetime,not null)
/// </summary>
public DateTime CreatedAt
{
	get { return createdAt; }
	set { createdAt = value; }
}

/// <summary>
/// Property relating to database column ModifiedBy(nvarchar(100),not null)
/// </summary>
public string ModifiedBy
{
	get { return modifiedBy; }
	set { modifiedBy = value; }
}

/// <summary>
/// Property relating to database column ModifiedAt(datetime,not null)
/// </summary>
public DateTime ModifiedAt
{
	get { return modifiedAt; }
	set { modifiedAt = value; }
}
#endregion
		
     }
}
