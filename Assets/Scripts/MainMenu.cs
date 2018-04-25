using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public bool quitButton;

    // Use this for initialization
    void Start () {

        Button btn = gameObject.GetComponent<Button>();

        if (quitButton)
        {
            btn.onClick.AddListener(TaskOnClickQuit);
        }
        else
        {
            btn.onClick.AddListener(TaskOnClickLoad);
        }
    }

    void TaskOnClickLoad()
    {
        SceneManager.LoadScene("Level1");
    }

    void TaskOnClickQuit()
    {
        print("Quit");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
