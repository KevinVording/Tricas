using UnityEngine;
using System.Collections;

public class SceneViewerOut : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    // Nothing
	}

    public void Awake()
    {
        Object.DontDestroyOnLoad(this.transform.gameObject);
    }

    public void changeSceneMain()
    {
        Application.LoadLevel("ITM Room");
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.CompareTag("mainScene"))
        {
            changeSceneMain();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	    // Nothing
	}
}