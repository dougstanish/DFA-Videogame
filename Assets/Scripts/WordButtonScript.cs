using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordButtonScript : MonoBehaviour {

    public ButtonManagerScript mg;
    Vector2 original;

	// Use this for initialization
	void Start () {
        original = transform.position;
        mg = GameObject.FindGameObjectWithTag("ButtonManager").GetComponent<ButtonManagerScript>();
        gameObject.GetComponent<Button>().onClick.AddListener(Press);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Press()
    {
        mg.ToggleButton(this);
    }

    public void Reset()
    {
        transform.position = original;
    }
}
