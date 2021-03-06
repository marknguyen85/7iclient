/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: LogError.cs 				   	     
File Description 	: LogError is the corresponding data object to tblLogError data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class LogError :BaseJsonEntity<LogError>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblLogError="tblLogError";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_ErrorCode="ErrorCode";
		public const string FIELD_ErrorMsg="ErrorMsg";
		#endregion
		
#region Members
protected int iD;
protected string errorCode;
protected string errorMsg;
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
/// Property relating to database column ErrorCode(nvarchar(50),not null)
/// </summary>
public string ErrorCode
{
	get { return errorCode; }
	set { errorCode = value; }
}

/// <summary>
/// Property relating to database column ErrorMsg(nvarchar(MAX),not null)
/// </summary>
public string ErrorMsg
{
	get { return errorMsg; }
	set { errorMsg = value; }
}
#endregion
		
     }
}
