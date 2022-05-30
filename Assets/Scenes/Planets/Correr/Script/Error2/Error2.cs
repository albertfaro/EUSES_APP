using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error2 : MonoBehaviour
{
    public GameObject errorBoy;
    public GameObject solutionBoy;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void whatDidIDoWrong()
    {
        if(solutionBoy.active==true)
        {
            solutionBoy.SetActive(false);
        }
        errorBoy.SetActive(true);
        errorBoy.SendMessage("activateAnim");
    }


    public void howToSolveIt()
    {
        errorBoy.SetActive(false);
        solutionBoy.SetActive(true);
        solutionBoy.SendMessage("activateAnim");
    }
}
