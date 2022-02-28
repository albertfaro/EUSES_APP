using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PreGameScript : MonoBehaviour
{
   public void onBackButton()
    {
        SceneManager.LoadScene("Profiles", LoadSceneMode.Single);
    }

    public void onStart()
    {
        SceneManager.LoadScene("Worlds", LoadSceneMode.Single);
    }


    public void onStyle()
    {
        SceneManager.LoadScene("CharacterEditor", LoadSceneMode.Single);
    }
}
