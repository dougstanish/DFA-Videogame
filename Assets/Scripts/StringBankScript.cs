using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringBankScript : MonoBehaviour {

    public Text bank;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddString(string s)
    {
        bank.text += s + "\n";
    }
}
