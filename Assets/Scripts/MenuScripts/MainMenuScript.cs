using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void playGame()
    {
        SceneManager.LoadScene("LoginMenu", LoadSceneMode.Single);
    }

    public void goToSettings()
    {
        SceneManager.LoadScene("SettingsMM", LoadSceneMode.Single);
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
   
