/*
Product Name		: UG	
Product Version 	: 1.0                                               	                     
Product Owner   	: UG-Trad
Developed By    	: 7i.com.vn

Description: Sync7i is project intergarte client SmartNet and web 7i.com.vn
						
File Name	   		: OrderItem.cs 				   	     
File Description 	: OrderItem is the corresponding data object to tblOrderItem data table

Copyright(C) 2013 by UG-Trad. All Rights Reserved 	
*/
using System;
using System.Collections.Generic;
using UG.Mobile.Framework;

namespace Sync7i.Mobile.BusinessEntities
{
	public partial class OrderItem :BaseJsonEntity<OrderItem>
	{
		public object Clone()
        {
            return this.MemberwiseClone();
        }
		public const string Table_TblOrderItem="tblOrderItem";
		#region Column Names
		
		public const string FIELD_Id="Id";
		public const string FIELD_SKU="SKU";
		public const string FIELD_OrderId="OrderId";
		public const string FIELD_Quantity="Quantity";
		public const string FIELD_Price="Price";
		#endregion
		
#region Members
protected int id;
protected string sKU;
protected int orderId;
protected int quantity;
protected decimal price;
#endregion
#region Public Properties

/// <summary>
/// Property relating to database column Id(int,not null)
/// </summary>
public int Id
{
	get { return id; }
	set { id = value; }
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
/// Property relating to database column OrderId(int,not null)
/// </summary>
public int OrderId
{
	get { return orderId; }
	set { orderId = value; }
}

/// <summary>
/// Property relating to database column Quantity(int,not null)
/// </summary>
public int Quantity
{
	get { return quantity; }
	set { quantity = value; }
}

/// <summary>
/// Property relating to database column Price(decimal(18,4),null)
/// </summary>
public decimal Price
{
	get { return price; }
	set { price = value; }
}
#endregion
		
     }
}
