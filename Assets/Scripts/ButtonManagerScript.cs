using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerScript : MonoBehaviour {

    static int MAX_BUTTONS = 12;
    WordButtonScript[] buttons = new WordButtonScript[MAX_BUTTONS];
    public string[] correctAnswers;
    public Text correct;
    public Button nextLevel;
    public GameObject fullReveal;
    bool solved;

	// Use this for initialization
	void Start () {
        solved = false;
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
            if (s.Equals(ans) && !solved)
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
            if(i == MAX_BUTTONS)
            {
                return;
            }
        }
        bt.gameObject.transform.position = new Vector2(700 + (i % 4) * 75, 650 - (i / 4) * 30);
        buttons[i] = bt;
    }

    public bool RemoveButton(WordButtonScript bt)
    {
        int ind = -1;
        for(int i = 0; i < MAX_BUTTONS; i++)
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
        for(int i = 0; i < MAX_BUTTONS; i++)
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
        solved = true;
        correct.transform.Translate(new Vector3(0, -500, 0));
        nextLevel.transform.Translate(new Vector3(0, -500, 0));
        fullReveal.transform.Translate(new Vector3(20, 0, 0));
    }
}


