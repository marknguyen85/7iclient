/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: NhapHang.cs 				   	     
File Description 	: NhapHang is the corresponding data object to tblNhapHang data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class NhapHang :BaseJsonEntity<NhapHang>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblNhapHang="tblNhapHang";
		#region Column Names
		
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_ID="ID";
		public const string FIELD_NCCID="NCCID";
		public const string FIELD_TenNCC="TenNCC";
		public const string FIELD_NgayGiao="NgayGiao";
		public const string FIELD_TrangThai="TrangThai";
		public const string FIELD_TongTien="TongTien";
		public const string FIELD_NgayTT="NgayTT";
		public const string FIELD_GhiChu="GhiChu";
		public const string FIELD_ConNo="ConNo";
		public const string FIELD_ChietKhau="ChietKhau";
		public const string FIELD_IncludeVAT="IncludeVAT";
		public const string FIELD_IsDeleted="IsDeleted";
		public const string FIELD_CreatedBy="CreatedBy";
		public const string FIELD_CreatedAt="CreatedAt";
		public const string FIELD_ModifiedBy="ModifiedBy";
		public const string FIELD_ModifiedAt="ModifiedAt";
		public const string FIELD_SyncDate="SyncDate";
		public const string FIELD_ItemVersion="ItemVersion";
		public const string FIELD_OnID="OnID";
		public const string FIELD_IsSpecial="IsSpecial";
		#endregion
		
#region Members
protected int locationStoreID;
protected int iD;
protected int nCCID;
protected string tenNCC;
protected DateTime ngayGiao;
protected int trangThai;
protected decimal tongTien;
protected DateTime ngayTT;
protected string ghiChu;
protected decimal conNo;
protected decimal chietKhau;
protected bool includeVAT;
protected bool isDeleted;
protected string createdBy;
protected DateTime createdAt;
protected string modifiedBy;
protected DateTime modifiedAt;
protected DateTime syncDate;
protected int itemVersion;
protected long onID;
protected bool isSpecial;
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
/// Property relating to database column NCCID(int,not null)
/// </summary>
public int NCCID
{
	get { return nCCID; }
	set { nCCID = value; }
}

/// <summary>
/// Property relating to database column TenNCC(nvarchar(100),null)
/// </summary>
public string TenNCC
{
	get { return tenNCC; }
	set { tenNCC = value; }
}

/// <summary>
/// Property relating to database column NgayGiao(date,not null)
/// </summary>
public DateTime ActualDate
{
	get { return ngayGiao; }
	set { ngayGiao = value; }
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
/// Property relating to database column TongTien(money,not null)
/// </summary>
public decimal TongTien
{
	get { return tongTien; }
	set { tongTien = value; }
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
/// Property relating to database column GhiChu(nvarchar(200),null)
/// </summary>
public string GhiChu
{
	get { return ghiChu; }
	set { ghiChu = value; }
}

/// <summary>
/// Property relating to database column ConNo(money,not null)
/// </summary>
public decimal ConNo
{
	get { return conNo; }
	set { conNo = value; }
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
/// Property relating to database column IncludeVAT(bit,null)
/// </summary>
public bool IncludeVAT
{
	get { return includeVAT; }
	set { includeVAT = value; }
}

/// <summary>
/// Property relating to database column IsDeleted(bit,null)
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

/// <summary>
/// Property relating to database column SyncDate(datetime,null)
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

/// <summary>
/// Property relating to database column OnID(bigint,not null)
/// </summary>
public long OnID
{
	get { return onID; }
	set { onID = value; }
}

/// <summary>
/// Property relating to database column IsSpecial(bit,null)
/// </summary>
public bool IsSpecial
{
	get { return isSpecial; }
	set { isSpecial = value; }
}
#endregion
		
     }
}
