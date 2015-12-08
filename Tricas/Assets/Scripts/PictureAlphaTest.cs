using UnityEngine;
using System.Collections;
using LMWidgets;

public class PictureAlphaTest : DataBinderSlider {

    private SpriteRenderer renderer = null;

    /// <summary>
    /// Finds the SpriteRenderer Component.
    /// Awake after initializing the data model.
    /// </summary>
    void Awake()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
        base.Awake();
    }

	//// Use this for initialization
	//void Start () {
	
	//}
	
	//// Update is called once per frame
	//void Update () {
	
	//}

    /// <summary>
    /// Sets the alpha value of the SpriteRenderer
    /// </summary>
    /// <param name="value"></param>
    override protected void setDataModel(float value)
    {
        Color currentColor = renderer.color;
        currentColor.a = value;
        renderer.color = currentColor;
    }

    /// <summary>
    /// Returns the current value of alpha
    /// Called once per frame.
    /// </summary>
    /// <returns></returns>
    override public float GetCurrentData()
    {
        return renderer.color.a;
    }
}
