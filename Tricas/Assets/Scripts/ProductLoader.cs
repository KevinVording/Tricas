using UnityEngine;
using System.Collections;
using System.IO;

public class ProductLoader : MonoBehaviour {

    public const string path = "products.xml";

	// Use this for initialization
	void Start () {
        
        ProductCache pC = ProductCache.Load(Path.Combine(Application.dataPath, path));

        //foreach(Product product in pC.products)
        //{
        //    print(product.productTitle);
        //}

        // Requires IEnumerator Start()

        //WWW www = new WWW(Path.Combine(Application.dataPath, path));
        //yield return www;
        //ProductCache pC = ProductCache.Load(www.text);

        //foreach(Product product in pC.products)
        //{
        //    print(product.productTitle);
        //}
    }
}