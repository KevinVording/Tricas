using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("ProductCollection")]
public class ProductCache {

    [XmlArray("Products")]
    [XmlArrayItem("Product")]
    public List<Product> products = new List<Product>();


    void Start()
    {
        
    }

    public static ProductCache Load(string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(ProductCache));
        FileStream stream = new FileStream(path, FileMode.Open);

        using (stream)
        { 
            return serializer.Deserialize(stream) as ProductCache;
        }
    }
	
}
