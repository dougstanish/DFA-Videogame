using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour {

    public StateScript state;
    StateScript startState;
    bool moving;
    Vector2 target;
    Vector2 dir;

    StringRecorderScript srs;

	// Use this for initialization
	void Start () {
        startState = state;
        srs = GameObject.FindGameObjectWithTag("StringRecorder").GetComponent<StringRecorderScript>();
	}
	
	// Update is called once per frame
	void Update () {
        if (moving)
        {
            if((target - new Vector2(transform.position.x, transform.position.y)).magnitude < dir.magnitude)
            {
                transform.position = target;
                moving = false;
            }
            else
            {
                transform.position = new Vector3(transform.position.x + dir.x, transform.position.y + dir.y);
            }
        }
        else
        {
            CheckKey();
        }
	}

    void CheckKey()
    {
        if (Input.GetKeyDown("a"))
        {
            ChangeStateA();
            srs.str.text += "a";
        }
        else if (Input.GetKeyDown("b"))
        {
            ChangeStateB();
            srs.str.text += "b";
        }
        else if (Input.GetKeyDown("escape"))
        {
            Reset();
            srs.str.text = "";
        }
        else if (Input.GetKeyDown("return"))
        {
            if (state.accept)
            {
                StringBankScript s = GameObject.FindGameObjectWithTag("Bank").GetComponent<StringBankScript>();
                if (srs.CheckUnique(s.bank.text))
                {
                    Reset();
                    s.AddString(srs.str.text);
                    srs.str.text = "";
                }
            }
        }
    }

    void ChangeStateA()
    {
        if (!state.Equals(state.onA))
        {
            state = state.onA;
            UpdatePosition();
        }
    }

    void ChangeStateB()
    {
        if (!state.Equals(state.onB))
        {
            state = state.onB;
            UpdatePosition();
        }
    }

    void UpdatePosition()
    {
        GameObject o = state.gameObject;
        target = o.transform.position;
        dir = (target - new Vector2(transform.position.x, transform.position.y)).normalized;
        dir.Scale(new Vector2(0.15f, 0.15f));
        moving = true;
    }

    public void Reset()
    {
        if (!state.Equals(startState))
        {
            state = startState;
            UpdatePosition();
        }
    }
}
