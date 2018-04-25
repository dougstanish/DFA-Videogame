using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringBankScript : MonoBehaviour {

    public Text bank;
    int stringCount;
    int STRING_MAX = 14;

	// Use this for initialization
	void Start () {
        stringCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddString(string s, bool accept)
    {
        if (accept) bank.text += s + " ✓\n";
        else bank.text += s + " ✘\n";
        stringCount++;
        if(stringCount > STRING_MAX)
        {
            bank.text = bank.text.Substring(bank.text.IndexOf('\n') + 1);
        }
    }
}
