using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class displayUICube : MonoBehaviour {

	private GameObject imgSprite;
	private GameObject myText;
	private Text tekstTitel;
	private Text tekstProduct;
	private Text tekstDescription;
	private string myString;
	private string preString;
	private string productCube;
	private string description;
	private bool displayInfo;
	
	public Texture[] newTextures;
	private RawImage img;
    private Texture imgTexture;

    public const string path = "products.xml";

    // Use this for initialization
    public IEnumerator Start () 
	{
        ProductCache pC = ProductCache.Load(Path.Combine(Application.dataPath, path));

        Product product = pC.products[0];

        Texture2D texture = new Texture2D(1024, 512);
        WWW www = new WWW(product.productImage);
        yield return www;

        www.LoadImageIntoTexture(texture);
        GetComponent<Renderer>().material.mainTexture = texture;

        imgTexture = texture;

        displayInfo = false;

            myString = product.productTitle; //"This is a Cube";
            preString = "Geen selectie gemaakt";
            productCube = product.productInfo; //"This is a Cube";
            description = product.productDescription; //"Lorum Ipsum Cube";

            myText = GameObject.FindGameObjectWithTag("testText");
            tekstTitel = (Text)myText.GetComponent<Text>();
            tekstTitel.text = preString;

            imgSprite = GameObject.FindGameObjectWithTag("imgSprite");
            img = (RawImage)imgSprite.GetComponent<RawImage>();
            // img.texture = (Texture)newTextures[0];

            myText = GameObject.FindGameObjectWithTag("productText");
            tekstProduct = (Text)myText.GetComponent<Text>();

            myText = GameObject.FindGameObjectWithTag("descriptionText");
            tekstDescription = (Text)myText.GetComponent<Text>();
        
	}

	public void OnMouseDown()
	{
		displayInfo = true;
	}

	public void OnMouseExit()
	{
		displayInfo = false;
	}

	// Update is called once per frame
	public void Update () 
	{
		if (displayInfo == true)
		{
            img.texture = imgTexture;// (Texture)newTextures [0];
			tekstTitel.text = myString;
			tekstProduct.text = productCube;
			tekstDescription.text = description;
		} 
		else 
		{
			// Do Nothing
			displayInfo = false;
		}
	}
}