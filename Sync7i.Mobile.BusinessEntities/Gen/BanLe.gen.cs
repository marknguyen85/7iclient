/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: BanLe.cs 				   	     
File Description 	: BanLe is the corresponding data object to tblBanLe data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class BanLe :BaseJsonEntity<BanLe>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblBanLe="tblBanLe";
		#region Column Names
		
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_ID="ID";
		public const string FIELD_CreatedBy="CreatedBy";
		public const string FIELD_CreatedAt="CreatedAt";
		public const string FIELD_ChietKhau="ChietKhau";
		public const string FIELD_TienHang="TienHang";
		public const string FIELD_TienVat="TienVat";
		public const string FIELD_TongTien="TongTien";
		public const string FIELD_ThanhToan="ThanhToan";
		public const string FIELD_LoaiThanhToan="LoaiThanhToan";
		public const string FIELD_GhiChu="GhiChu";
		public const string FIELD_SyncDate="SyncDate";
		public const string FIELD_ModifiedBy="ModifiedBy";
		public const string FIELD_ModifiedAt="ModifiedAt";
		public const string FIELD_IsDeleted="IsDeleted";
		public const string FIELD_MaMobile="MaMobile";
		public const string FIELD_ItemVersion="ItemVersion";
		public const string FIELD_OnID="OnID";
		public const string FIELD_QuayBanHangID="QuayBanHangID";
		public const string FIELD_IsDistribution="IsDistribution";
		public const string FIELD_TrangThai="TrangThai";
		public const string FIELD_NgayTT="NgayTT";
		public const string FIELD_TongDon="TongDon";
		#endregion
		
#region Members
protected int locationStoreID;
protected int iD;
protected string createdBy;
protected DateTime createdAt;
protected decimal chietKhau;
protected decimal tienHang;
protected decimal tienVat;
protected decimal tongTien;
protected decimal thanhToan;
protected string loaiThanhToan;
protected string ghiChu;
protected DateTime syncDate;
protected string modifiedBy;
protected DateTime modifiedAt;
protected bool isDeleted;
protected string maMobile;
protected int itemVersion;
protected long onID;
protected int quayBanHangID;
protected bool isDistribution;
protected int trangThai;
protected DateTime ngayTT;
protected decimal tongDon;
		protected DateTime actualDate;
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
/// Property relating to database column ChietKhau(money,not null)
/// </summary>
public decimal ChietKhau
{
	get { return chietKhau; }
	set { chietKhau = value; }
}

/// <summary>
/// Property relating to database column TienHang(money,not null)
/// </summary>
public decimal TienHang
{
	get { return tienHang; }
	set { tienHang = value; }
}

/// <summary>
/// Property relating to database column TienVat(money,not null)
/// </summary>
public decimal TienVat
{
	get { return tienVat; }
	set { tienVat = value; }
}

/// <summary>
/// Property relating to database column TongTien(money,not null)
/// </summary>
public decimal TongTien
{
	get { return tongTien; }
	set { tongTien = value; }
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
/// Property relating to database column LoaiThanhToan(varchar(20),not null)
/// </summary>
public string LoaiThanhToan
{
	get { return loaiThanhToan; }
	set { loaiThanhToan = value; }
}

/// <summary>
/// Property relating to database column GhiChu(nvarchar(250),null)
/// </summary>
public string GhiChu
{
	get { return ghiChu; }
	set { ghiChu = value; }
}

/// <summary>
/// Property relating to database column SyncDate(datetime,null)
/// </summary>
public DateTime SyncDate
{
	get { return syncDate; }
	set { syncDate = value; }
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

/// <summary>
/// Property relating to database column IsDeleted(bit,not null)
/// </summary>
public bool IsDeleted
{
	get { return isDeleted; }
	set { isDeleted = value; }
}

/// <summary>
/// Property relating to database column MaMobile(varchar(11),null)
/// </summary>
public string MaMobile
{
	get { return maMobile; }
	set { maMobile = value; }
}

/// <summary>
/// Property relating to database column ItemVersion(int,null)
/// </summary>
public int ItemVersion
{
	get { return itemVersion; }
	set { itemVersion = value; }
}

/// <summary>
/// Property relating to database column OnID(bigint,not null)
/// </summary>
public long OnID
{
	get { return onID; }
	set { onID = value; }
}

/// <summary>
/// Property relating to database column QuayBanHangID(int,not null)
/// </summary>
public int QuayBanHangID
{
	get { return quayBanHangID; }
	set { quayBanHangID = value; }
}

/// <summary>
/// Property relating to database column IsDistribution(bit,not null)
/// </summary>
public bool IsDistribution
{
	get { return isDistribution; }
	set { isDistribution = value; }
}

/// <summary>
/// Property relating to database column TrangThai(int,not null)
/// </summary>
public int TrangThai
{
	get { return trangThai; }
	set { trangThai = value; }
}

/// <summary>
/// Property relating to database column NgayTT(date,not null)
/// </summary>
public DateTime NgayTT
{
	get { return ngayTT; }
	set { ngayTT = value; }
}

/// <summary>
/// Property relating to database column TongDon(money,not null)
/// </summary>
public decimal TongDon
{
	get { return tongDon; }
	set { tongDon = value; }
}
		public DateTime ActualDate
		{
			get { return actualDate; }
			set { actualDate = value; }
		}
#endregion
		
     }
}
