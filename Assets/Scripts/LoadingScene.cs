using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("AnimSC", LoadSceneMode.Single);
    }
}
