using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayUISphere : MonoBehaviour {

	private GameObject imgSprite;
	private GameObject myText;
	private Text tekstTitel;
	private Text tekstProduct;
	private Text tekstDescription;
	private string myString;
	private string preString;
	private string product;
	private string description;
	private bool displayInfo;
	
	public Texture[] newTextures;
	private RawImage img;
	
	// Use this for initialization
	public void Start ()
	{
		displayInfo = false;
		
		myString = "This is a Sphere";
		preString = "Geen selectie gemaakt";
		product = "This is a Sphere";
		description = "Lorum Ipsum Sphere";
		
		myText = GameObject.FindGameObjectWithTag ("testText");
		tekstTitel = (Text)myText.GetComponent<Text>();
		tekstTitel.text = preString;
		
		imgSprite = GameObject.FindGameObjectWithTag ("imgSprite");
		img = (RawImage)imgSprite.GetComponent<RawImage> ();
		// img.texture = (Texture)newTextures[0];
		
		myText = GameObject.FindGameObjectWithTag ("productText");
		tekstProduct = (Text)myText.GetComponent<Text> ();
		
		myText = GameObject.FindGameObjectWithTag ("descriptionText");
		tekstDescription = (Text)myText.GetComponent<Text> ();
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
			img.texture = (Texture)newTextures [0];
			tekstTitel.text = myString;
			tekstProduct.text = product;
			tekstDescription.text = description;
		} 
		else 
		{
			// Do Nothing
			displayInfo = false;
		}
	}
}