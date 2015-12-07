using UnityEngine;
using System.Collections;

public class CanvasAnimatorController : MonoBehaviour {

	// Calling on the Animator component in all children in the object.
	protected Animator[] children;
	// Minimum Distance before Animation is called on.
	public float minDistance;
	// Boolean to indicate if the Animation is showing.
	public bool showing;
	//private Animation anim;

	// Use this for initialization
	void Start () {
		children = GetComponentsInChildren<Animator>();
		//anim = GetComponentInChildren<Animation> ();
		showing = false;
		for (int a = 0; a < children.Length; a++)
		{
			children[a].SetBool("Shown", showing);
		}
	}

	/// <summary>
	/// Method that checks if the object tagged Player is inside the collider.
	/// </summary>
	/// <param name="Col">Collider</param>
	/*public void OnTriggerEnter(Collider Col)
	{
		if(Col.gameObject.CompareTag("Player"))
		{
			showing = true;
		}
	}
	
	/// <summary>
	/// Method that checks if the object tagged Player is outside the collider.
	/// </summary>
	/// <param name="Col">Collider</param>
	public void OnTriggerExit(Collider Col)
	{
		if(Col.gameObject.CompareTag("Player"))
		{
			showing = false;
		}
	}*/
	
	// Update is called once per frame
	public void Update () {
		Vector3 delta = Camera.main.transform.position - transform.position;
		if (delta.magnitude < minDistance) {
			if (showing) return;
			showing = true;
			for (int a = 0; a < children.Length; a++)
			{
				children[a].SetBool("Shown", true);
			}
		} else {
			if (! showing) return;
			showing = false;
			for (int a = 0; a < children.Length; a++)
			{
				children[a].SetBool("Shown", false);
			}
		}
		/*if (showing == true) {
			anim.Play("FadeIn");
		} else {
			anim.Stop("FadeIn");
		}*/
	}
}