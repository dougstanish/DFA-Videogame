using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringRecorderScript : MonoBehaviour {

    public Text str;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        CheckKey();
	}

    void CheckKey()
    {
        if (Input.GetKeyDown("a"))
        {
            str.text += "a";
        }
        else if (Input.GetKeyDown("b"))
        {
            str.text += "b";
        }
        else if (Input.GetKeyDown("escape"))
        {
            IndicatorScript i = GameObject.FindGameObjectWithTag("Indicator").GetComponent<IndicatorScript>();
            i.Reset();
            str.text = "";
        }
        else if (Input.GetKeyDown("return"))
        {
            IndicatorScript i = GameObject.FindGameObjectWithTag("Indicator").GetComponent<IndicatorScript>();
            if (i.state.accept)
            {
                StringBankScript s = GameObject.FindGameObjectWithTag("Bank").GetComponent<StringBankScript>();
                if (CheckUnique(s.bank.text))
                {
                    i.Reset();
                    s.AddString(str.text);
                    str.text = "";
                }
            }
        }
    }

    bool CheckUnique(string s)
    {
        foreach (string word in s.Split('\n'))
        {
            if (str.text.Equals(word)) return false;
        }
        return true;
    }
}
