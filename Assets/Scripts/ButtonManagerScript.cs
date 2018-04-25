using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerScript : MonoBehaviour {

    WordButtonScript[] buttons = new WordButtonScript[8];
    public string[] correctAnswers;
    public Text correct;
    public Button nextLevel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PressButton()
    {

    }

    public void ToggleButton(WordButtonScript bt)
    {
        if (!RemoveButton(bt))
        {
            AddButton(bt);
        }
        string s = CalculateSentence();
        foreach(string ans in correctAnswers)
        {
            if (s.Equals(ans))
            {
                NextLevel();
            }
        }
    }

    public void AddButton(WordButtonScript bt)
    {
        int i = 0;
        while (buttons[i] != null)
        {
            i++;
            if(i == 8)
            {
                return;
            }
        }
        bt.gameObject.transform.position = new Vector2(600 + (i % 4) * 75, 350 - (i / 4) * 30);
        buttons[i] = bt;
    }

    public bool RemoveButton(WordButtonScript bt)
    {
        int ind = -1;
        for(int i = 0; i < 8; i++)
        {
            if (buttons[i] != null && buttons[i].Equals(bt))
            {
                ind = i;
            }
        }
        if (ind == -1) return false;

        bt.Reset();
        buttons[ind] = null;

        return true;
    }

    public string CalculateSentence()
    {
        string ret = "";
        for(int i = 0; i < 8; i++)
        {
            WordButtonScript b = buttons[i];
            if(b != null)
            {
                ret += b.gameObject.GetComponentInChildren<Text>().text + " ";
            }
            else
            {
                return ret;
            }
        }
        return ret;
    }

    void NextLevel(){
        correct.transform.Translate(new Vector3(0, -200, 0));
        nextLevel.transform.Translate(new Vector3(0, -200, 0));
    }
}


