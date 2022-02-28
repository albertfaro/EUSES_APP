using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnimMenuScript : MonoBehaviour
{
    void Start()
    {
    StartCoroutine(WaitAndPlay());
    
    }

    IEnumerator WaitAndPlay()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
