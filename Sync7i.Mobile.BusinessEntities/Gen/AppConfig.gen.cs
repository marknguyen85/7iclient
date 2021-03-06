/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: AppConfig.cs 				   	     
File Description 	: AppConfig is the corresponding data object to tblAppConfig data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class AppConfig :BaseJsonEntity<AppConfig>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblAppConfig="tblAppConfig";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_ConfigKey="ConfigKey";
		public const string FIELD_ConfigData="ConfigData";
		public const string FIELD_DataType="DataType";
		public const string FIELD_IsEncryption="IsEncryption";
		#endregion
		
#region Members
protected int iD;
protected string configKey;
protected string configData;
protected string dataType;
protected bool isEncryption;
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
/// Property relating to database column ConfigKey(varchar(50),not null)
/// </summary>
public string ConfigKey
{
	get { return configKey; }
	set { configKey = value; }
}

/// <summary>
/// Property relating to database column ConfigData(nvarchar(MAX),not null)
/// </summary>
public string ConfigData
{
	get { return configData; }
	set { configData = value; }
}

/// <summary>
/// Property relating to database column DataType(varchar(500),null)
/// </summary>
public string DataType
{
	get { return dataType; }
	set { dataType = value; }
}

/// <summary>
/// Property relating to database column IsEncryption(bit,null)
/// </summary>
public bool IsEncryption
{
	get { return isEncryption; }
	set { isEncryption = value; }
}
#endregion
		
     }
}
