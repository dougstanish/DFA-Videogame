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
        
    }

    public bool CheckUnique(string s)
    {
        foreach (string word in s.Split('\n'))
        {
            if (word.Length >= 2 && str.text.Equals(word.Substring(0, word.Length - 2))) return false;
        }
        return true;
    }
}
