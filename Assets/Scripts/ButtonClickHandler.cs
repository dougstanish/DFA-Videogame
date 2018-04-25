using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour {

    public GameObject button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void SetButton(GameObject g)
    {
        button = g;
        button.GetComponent<Button>().onClick.AddListener(PressButton);
    }

    void PressButton()
    {
        button.GetComponent<WordButtonScript>().Press();
    }
}
