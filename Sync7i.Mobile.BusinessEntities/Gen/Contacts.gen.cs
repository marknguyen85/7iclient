/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: Contacts.cs 				   	     
File Description 	: Contacts is the corresponding data object to tblContacts data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class Contacts :BaseJsonEntity<Contacts>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblContacts="tblContacts";
		#region Column Names
		
		public const string FIELD_ID="ID";
		public const string FIELD_Name="Name";
		public const string FIELD_Position="Position";
		public const string FIELD_Phone="Phone";
		public const string FIELD_Mobile="Mobile";
		public const string FIELD_Fax="Fax";
		public const string FIELD_Email="Email";
		public const string FIELD_StreetAddress="StreetAddress";
		public const string FIELD_City="City";
		public const string FIELD_Country="Country";
		public const string FIELD_WebURL="WebURL";
		public const string FIELD_ImageURL="ImageURL";
		#endregion
		
#region Members
protected int iD;
protected string name;
protected string position;
protected string phone;
protected string mobile;
protected string fax;
protected string email;
protected string streetAddress;
protected string city;
protected string country;
protected string webURL;
protected string imageURL;
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
/// Property relating to database column Name(nvarchar(50),not null)
/// </summary>
public string Name
{
	get { return name; }
	set { name = value; }
}

/// <summary>
/// Property relating to database column Position(nvarchar(50),null)
/// </summary>
public string Position
{
	get { return position; }
	set { position = value; }
}

/// <summary>
/// Property relating to database column Phone(varchar(15),null)
/// </summary>
public string Phone
{
	get { return phone; }
	set { phone = value; }
}

/// <summary>
/// Property relating to database column Mobile(varchar(15),not null)
/// </summary>
public string Mobile
{
	get { return mobile; }
	set { mobile = value; }
}

/// <summary>
/// Property relating to database column Fax(varchar(15),null)
/// </summary>
public string Fax
{
	get { return fax; }
	set { fax = value; }
}

/// <summary>
/// Property relating to database column Email(nvarchar(50),null)
/// </summary>
public string Email
{
	get { return email; }
	set { email = value; }
}

/// <summary>
/// Property relating to database column StreetAddress(nvarchar(250),null)
/// </summary>
public string StreetAddress
{
	get { return streetAddress; }
	set { streetAddress = value; }
}

/// <summary>
/// Property relating to database column City(nvarchar(50),null)
/// </summary>
public string City
{
	get { return city; }
	set { city = value; }
}

/// <summary>
/// Property relating to database column Country(nvarchar(50),null)
/// </summary>
public string Country
{
	get { return country; }
	set { country = value; }
}

/// <summary>
/// Property relating to database column WebURL(nvarchar(250),null)
/// </summary>
public string WebURL
{
	get { return webURL; }
	set { webURL = value; }
}

/// <summary>
/// Property relating to database column ImageURL(nvarchar(250),null)
/// </summary>
public string ImageURL
{
	get { return imageURL; }
	set { imageURL = value; }
}
#endregion
		
     }
}
