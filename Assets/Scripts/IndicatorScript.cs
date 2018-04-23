using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour {

    public StateScript state;
    StateScript startState;

	// Use this for initialization
	void Start () {
        startState = state;
	}
	
	// Update is called once per frame
	void Update () {
        CheckKey();
	}

    void CheckKey()
    {
        if (Input.GetKeyDown("a"))
        {
            ChangeStateA();
        }
        else if (Input.GetKeyDown("b"))
        {
            ChangeStateB();
        }
    }

    void ChangeStateA()
    {
        state = state.onA;
        UpdatePosition();
    }

    void ChangeStateB()
    {
        state = state.onB;
        UpdatePosition();
    }

    void UpdatePosition()
    {
        GameObject o = state.gameObject;
        transform.position = o.transform.position;
    }

    public void Reset()
    {
        state = startState;
        UpdatePosition();
    }
}
