using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error1 : MonoBehaviour
{

    public GameObject errorBoy;
    public GameObject solutionBoy;
    public GameObject currentCanvas;
    public GameObject goodCanvas;

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

        solutionBoy.SetActive(false);
        errorBoy.SetActive(true);
        errorBoy.SendMessage("activateAnim");
    }


    public void howToSolveIt()
    {
        errorBoy.SetActive(false);
        solutionBoy.SetActive(true);
        solutionBoy.SendMessage("activateAnim");
    }

    public void getBack()
    {
        currentCanvas.SetActive(false);
        goodCanvas.SetActive(true);
    }
}
