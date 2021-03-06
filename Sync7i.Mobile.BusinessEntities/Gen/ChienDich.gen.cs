/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: ChienDich.cs 				   	     
File Description 	: ChienDich is the corresponding data object to tblChienDich data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class ChienDich :BaseJsonEntity<ChienDich>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblChienDich="tblChienDich";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_Name="Name";
		public const string FIELD_Slogan="Slogan";
		public const string FIELD_Parent="Parent";
		public const string FIELD_Description="Description";
		public const string FIELD_DoanhSo="DoanhSo";
		public const string FIELD_ChiPhi="ChiPhi";
		public const string FIELD_NgayBD="NgayBD";
		public const string FIELD_NgayKT="NgayKT";
		public const string FIELD_TrangThai="TrangThai";
		public const string FIELD_IsDeleted="IsDeleted";
		public const string FIELD_CreatedBy="CreatedBy";
		public const string FIELD_CreatedAt="CreatedAt";
		public const string FIELD_ModifiedBy="ModifiedBy";
		public const string FIELD_ModifiedAt="ModifiedAt";
		public const string FIELD_IsTime="IsTime";
		public const string FIELD_GroupID="GroupID";
		public const string FIELD_ComID="ComID";
		#endregion
		
#region Members
protected int iD;
protected string name;
protected string slogan;
protected int parent;
protected string description;
protected decimal doanhSo;
protected decimal chiPhi;
protected DateTime ngayBD;
protected DateTime ngayKT;
protected int trangThai;
protected bool isDeleted;
protected string createdBy;
protected DateTime createdAt;
protected string modifiedBy;
protected DateTime modifiedAt;
protected bool isTime;
protected int groupID;
protected int comID;
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
/// Property relating to database column Name(nvarchar(500),not null)
/// </summary>
public string Name
{
	get { return name; }
	set { name = value; }
}

/// <summary>
/// Property relating to database column Slogan(nvarchar(250),null)
/// </summary>
public string Slogan
{
	get { return slogan; }
	set { slogan = value; }
}

/// <summary>
/// Property relating to database column Parent(int,null)
/// </summary>
public int Parent
{
	get { return parent; }
	set { parent = value; }
}

/// <summary>
/// Property relating to database column Description(nvarchar(1000),null)
/// </summary>
public string Description
{
	get { return description; }
	set { description = value; }
}

/// <summary>
/// Property relating to database column DoanhSo(money,null)
/// </summary>
public decimal DoanhSo
{
	get { return doanhSo; }
	set { doanhSo = value; }
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
/// Property relating to database column NgayBD(datetime,null)
/// </summary>
public DateTime NgayBD
{
	get { return ngayBD; }
	set { ngayBD = value; }
}

/// <summary>
/// Property relating to database column NgayKT(datetime,null)
/// </summary>
public DateTime NgayKT
{
	get { return ngayKT; }
	set { ngayKT = value; }
}

/// <summary>
/// Property relating to database column TrangThai(int,null)
/// </summary>
public int TrangThai
{
	get { return trangThai; }
	set { trangThai = value; }
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
/// Property relating to database column IsTime(bit,null)
/// </summary>
public bool IsTime
{
	get { return isTime; }
	set { isTime = value; }
}

/// <summary>
/// Property relating to database column GroupID(int,null)
/// </summary>
public int GroupID
{
	get { return groupID; }
	set { groupID = value; }
}
public virtual ComGroupStore ComGroupStore{get;set;}

/// <summary>
/// Property relating to database column ComID(int,null)
/// </summary>
public int ComID
{
	get { return comID; }
	set { comID = value; }
}
public virtual Companies Companies{get;set;}
#endregion
		
     }
}
