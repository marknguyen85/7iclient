/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: ThuKhac.cs 				   	     
File Description 	: ThuKhac is the corresponding data object to tblThuKhac data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class ThuKhac :BaseJsonEntity<ThuKhac>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblThuKhac="tblThuKhac";
		#region Column Names
		
		public const string FIELD_LocationStoreID="LocationStoreID";
		public const string FIELD_ID="ID";
		public const string FIELD_NgayThu="NgayThu";
		public const string FIELD_NguoiNop="NguoiNop";
		public const string FIELD_SoTien="SoTien";
		public const string FIELD_LyDo="LyDo";
		public const string FIELD_IsDeleted="IsDeleted";
		public const string FIELD_CreatedBy="CreatedBy";
		public const string FIELD_CreatedAt="CreatedAt";
		public const string FIELD_ModifiedBy="ModifiedBy";
		public const string FIELD_ModifiedAt="ModifiedAt";
		public const string FIELD_IsTamUng="IsTamUng";
		public const string FIELD_SyncDate="SyncDate";
		public const string FIELD_LoaiThu="LoaiThu";
		public const string FIELD_ItemVersion="ItemVersion";
		public const string FIELD_OnID="OnID";
		#endregion
		
#region Members
protected int locationStoreID;
protected int iD;
protected DateTime ngayThu;
protected string nguoiNop;
protected decimal soTien;
protected string lyDo;
protected bool isDeleted;
protected string createdBy;
protected DateTime createdAt;
protected string modifiedBy;
protected DateTime modifiedAt;
protected bool isTamUng;
protected DateTime syncDate;
protected int loaiThu;
protected int itemVersion;
protected long onID;
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
/// Property relating to database column NgayThu(date,null)
/// </summary>
public DateTime ActualDate
{
	get { return ngayThu; }
	set { ngayThu = value; }
}

/// <summary>
/// Property relating to database column NguoiNop(nvarchar(50),null)
/// </summary>
public string NguoiNop
{
	get { return nguoiNop; }
	set { nguoiNop = value; }
}

/// <summary>
/// Property relating to database column SoTien(money,null)
/// </summary>
public decimal SoTien
{
	get { return soTien; }
	set { soTien = value; }
}

/// <summary>
/// Property relating to database column LyDo(nvarchar(500),null)
/// </summary>
public string LyDo
{
	get { return lyDo; }
	set { lyDo = value; }
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
/// Property relating to database column IsTamUng(bit,null)
/// </summary>
public bool IsTamUng
{
	get { return isTamUng; }
	set { isTamUng = value; }
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
/// Property relating to database column LoaiThu(int,null)
/// </summary>
public int LoaiThu
{
	get { return loaiThu; }
	set { loaiThu = value; }
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
#endregion
		
     }
}
