using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAlive : MonoBehaviour
{

    static KeepAlive instance = null;

    void Awake()
    {

        if(instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
       
    }

}
