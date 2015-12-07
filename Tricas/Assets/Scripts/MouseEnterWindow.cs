using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseEnterWindow : MonoBehaviour {

	private GameObject popText;
	private GameObject popUpWindow;
	private Text cubeText;
	// private Text sphereText;
	private string cubeString;
	// private string sphereString;
	private bool showPopup;

	// Use this for initialization
	public void Start () 
	{
		cubeString = "Product: Cube";
		// sphereString = "Product: Sphere;";
		showPopup = false;
		popUpWindow = GameObject.FindGameObjectWithTag ("popUpWindow");
		popUpWindow.GetComponent<Canvas>().enabled = false;
		popText = GameObject.FindGameObjectWithTag ("popupText");
		cubeText = (Text)popText.GetComponent<Text> ();
	}

	public void OnMouseOver()
	{
		showPopup = true;
		popUpWindow.GetComponent<Canvas>().enabled = true;
	}

	public void OnMouseExit()
	{
		showPopup = false;
		popUpWindow.GetComponent<Canvas>().enabled = false;
	}
	
	// Update is called once per frame
	public void Update () 
	{
		if (showPopup == true) 
		{
			cubeText.text = cubeString;
			popUpWindow.GetComponent<Canvas>().enabled = true;
		} 
	}
}