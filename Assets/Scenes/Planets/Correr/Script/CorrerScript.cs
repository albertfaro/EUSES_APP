using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrerScript : MonoBehaviour
{
    public GameObject CorrectRun;
    public GameObject JudgeRun;
    public GameObject YouDidWell;
    public GameObject NeedToImprove;
    public GameObject Error1;
    public GameObject Error2;
    public GameObject Error3;
    public GameObject Error4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goBackToPlanet()
    {
        SceneManager.LoadScene("Worlds");
    }

    public void startCorrectRunFromWell()
    {
        YouDidWell.SetActive(false);
        CorrectRun.SetActive(true);
    }
    public void finishedCorrectRun()
    {
        CorrectRun.SetActive(false);
        JudgeRun.SetActive(true);
    }
   
    public void youDidWell()
    {
        JudgeRun.SetActive(false);
        YouDidWell.SetActive(true);
    }

    public void needToImprove()
    {
        JudgeRun.SetActive(false);
        NeedToImprove.SetActive(true);
    }

    public void error1FromBad()
    {
        NeedToImprove.SetActive(false);
        Error1.SetActive(true);
    }

    public void error2FromBad()
    {
        NeedToImprove.SetActive(false);
        Error2.SetActive(true);
    }

    public void error3FromBad()
    {
        NeedToImprove.SetActive(false);
        Error3.SetActive(true);
    }

    public void error4FromBad()
    {
        NeedToImprove.SetActive(false);
        Error4.SetActive(true);
    }

    public void getBack()
    {

    }
}
