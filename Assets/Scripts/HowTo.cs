using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowTo : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClickBack);


    }

    void TaskOnClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
