using UnityEngine;
using System.Collections;

public class CreateOutline : MonoBehaviour {

	private Color startColor;
	private GameObject meshRenderer;

	// Use this for initialization
	public void Start () 
	{
		startColor = gameObject.GetComponent<Renderer>().material.color;
	}

	public void OnMouseEnter()
	{
		gameObject.GetComponent<Renderer>().material.color = Color.green;
	}

	public void OnMouseExit()
	{
		gameObject.GetComponent<Renderer>().material.color = startColor;
	}

	// Update is called once per frame
	public void Update () 
	{
		//Nothing
	}
}
