/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: ChienDichCT.cs 				   	     
File Description 	: ChienDichCT is the corresponding data object to tblChienDichCT data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class ChienDichCT :BaseJsonEntity<ChienDichCT>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblChienDichCT="tblChienDichCT";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_SKU="SKU";
		public const string FIELD_Name="Name";
		public const string FIELD_DVT="DVT";
		public const string FIELD_GiaNhap="GiaNhap";
		public const string FIELD_GiaNY="GiaNY";
		public const string FIELD_GiaChienDich="GiaChienDich";
		public const string FIELD_SKUKM="SKUKM";
		public const string FIELD_NameKM="NameKM";
		public const string FIELD_ChienDichID="ChienDichID";
		#endregion
		
#region Members
protected int iD;
protected string sKU;
protected string name;
protected string dVT;
protected decimal giaNhap;
protected decimal giaNY;
protected decimal giaChienDich;
protected string sKUKM;
protected string nameKM;
protected int chienDichID;
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
/// Property relating to database column Name(nvarchar(1000),not null)
/// </summary>
public string Name
{
	get { return name; }
	set { name = value; }
}

/// <summary>
/// Property relating to database column DVT(nvarchar(50),not null)
/// </summary>
public string DVT
{
	get { return dVT; }
	set { dVT = value; }
}

/// <summary>
/// Property relating to database column GiaNhap(money,null)
/// </summary>
public decimal GiaNhap
{
	get { return giaNhap; }
	set { giaNhap = value; }
}

/// <summary>
/// Property relating to database column GiaNY(money,not null)
/// </summary>
public decimal GiaNY
{
	get { return giaNY; }
	set { giaNY = value; }
}

/// <summary>
/// Property relating to database column GiaChienDich(money,not null)
/// </summary>
public decimal GiaChienDich
{
	get { return giaChienDich; }
	set { giaChienDich = value; }
}

/// <summary>
/// Property relating to database column SKUKM(varchar(20),null)
/// </summary>
public string SKUKM
{
	get { return sKUKM; }
	set { sKUKM = value; }
}

/// <summary>
/// Property relating to database column NameKM(nvarchar(1000),null)
/// </summary>
public string NameKM
{
	get { return nameKM; }
	set { nameKM = value; }
}

/// <summary>
/// Property relating to database column ChienDichID(int,not null)
/// </summary>
public int ChienDichID
{
	get { return chienDichID; }
	set { chienDichID = value; }
}
public virtual ChienDich ChienDich{get;set;}
#endregion
		
     }
}
