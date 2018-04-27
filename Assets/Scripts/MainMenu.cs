using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public bool quitButton;
    public bool howTo;

    // Use this for initialization
    void Start () {

        Button btn = gameObject.GetComponent<Button>();

        if (quitButton)
        {
            btn.onClick.AddListener(TaskOnClickQuit);
        }
        else if (howTo)
        {
            btn.onClick.AddListener(TaskOnClickHow);
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

    void TaskOnClickHow()
    {
        SceneManager.LoadScene("Rules");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
