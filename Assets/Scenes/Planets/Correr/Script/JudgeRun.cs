using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeRun : MonoBehaviour
{

    public GameObject general;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void youDidWell()
    {
        general.SendMessage("youDidWell");
    }

    public void needToImprove()
    {
        general.SendMessage("needToImprove");
    }
}
