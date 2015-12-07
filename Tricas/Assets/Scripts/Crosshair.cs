using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour 
{

	public Texture2D crosshair;
	private Rect position;
	private bool isOn;

	// Use this for initialization
	void Start () 
	{
		isOn = true;
	}

	// Update is called once per frame
	void Update () 
	{
		position = new Rect ((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);

	}

	private void OnGUI()
	{
		if (isOn == true) 
		{
			GUI.DrawTexture(position, crosshair);
			Cursor.visible = true;
		}
	}
}
