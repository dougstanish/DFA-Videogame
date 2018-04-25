using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelButtonScript : MonoBehaviour {

    public string nextLevel;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Press);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void Press()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
