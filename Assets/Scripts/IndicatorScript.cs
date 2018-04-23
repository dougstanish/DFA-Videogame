using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour {

    public StateScript state;

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
        updatePosition();
    }

    void ChangeStateB()
    {
        state = state.onB;
        updatePosition();
    }

    void updatePosition()
    {
        GameObject o = state.gameObject;
        transform.position = o.transform.position;
    }
}
