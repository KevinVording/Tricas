using UnityEngine;
using System.Collections;

public class SceneViewer : MonoBehaviour {

	// Initialization
	void Start ()
    {
	    // Nothing
	}

    /// <summary>
    /// Function to make sure objects aren't destroyed when loaded into a new scene.
    /// </summary>
    public void Awake()
    {
        Object.DontDestroyOnLoad(this.transform.gameObject);
    }

    /// <summary>
    /// Functions to load a new scene, later to be called onto for the right scene.
    /// </summary>
    public void changeSceneWerkplaats()
    {
        Application.LoadLevel("Werkplaats");
    }

    public void changeSceneLab()
    {
        Application.LoadLevel("Lab");
    }

    public void changeSceneMaterialen()
    {
        Application.LoadLevel("Materialen");
    }

    public void changeSceneOntwerp()
    {
        Application.LoadLevel("Ontwerp");
    }

    public void changeSceneFEM()
    {
        Application.LoadLevel("FEM");
    }

    public void changeSceneTeken()
    {
        Application.LoadLevel("Teken");
    }

    public void changeSceneShowroom()
    {
        Application.LoadLevel("Showroom");
    }

    /// <summary>
    /// Collision triggers a scene change.
    /// </summary>
    /// <param name="Col">Collider variable</param>
    public void OnTriggerEnter(Collider Col)
    {
        // Detects the collision between player and collider.
        if (Col.gameObject.CompareTag("Werkplaats"))
        {
            changeSceneWerkplaats();
        }

        if (Col.gameObject.CompareTag("Lab"))
        {
            changeSceneLab();
        }

        if (Col.gameObject.CompareTag("Materialen"))
        {
            changeSceneMaterialen();
        }

        if (Col.gameObject.CompareTag("Ontwerp"))
        {
            changeSceneOntwerp();
        }

        if (Col.gameObject.CompareTag("FEM"))
        {
            changeSceneFEM();
        }

        if (Col.gameObject.CompareTag("Teken"))
        {
            changeSceneTeken();
        }

        if (Col.gameObject.CompareTag("Showroom"))
        {
            changeSceneShowroom();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Nothing
    }
}
