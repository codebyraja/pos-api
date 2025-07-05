﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace POS.Services.DBContext
{
    internal class POShelper
    {
        public static string CreateXML(object YourClassObject)
        {
            XmlDocument xmlDoc = new XmlDocument(); //Represents an XML document,
             // Initializes a new instance of the XmlDocument class.
            XmlSerializer xmlSerializer = new XmlSerializer(YourClassObject.GetType());
            // Creates a stream whose backing store is memory.
            using (MemoryStream xmlStream =  new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, YourClassObject);
                xmlStream.Position = 0;
                //Loads the XML document from the specified string.
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }
    }
}
