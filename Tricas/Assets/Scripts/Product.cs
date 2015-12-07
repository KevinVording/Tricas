using UnityEngine;
using System;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Product
{
    [XmlElement("ID")]
	public int productID;
    [XmlAttribute("name")]
	public string productTitle;
    [XmlElement("Info")]
	public string productInfo;
    [XmlElement("Description")]
    public string productDescription;
    [XmlElement("Image")]
    public string productImage;

	//override public string ToString()
	//{
	//	string returnString = "id: " + Convert.ToInt16(productID);
	//	returnString += "\r\nTitle: " + productTitle;
	//	returnString += "\r\nInfo: " + productInfo;
	//	returnString += "\r\nImage: " + productImage;
	//	returnString += "\r\nDescription: " + productDescription;
		
	//	return returnString;
	//}

	// Use this for initialization
}