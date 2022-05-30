using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedToImprove : MonoBehaviour
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

    public void Error1()
    {
        general.SendMessage("error1FromBad");
    }

    public void Error2()
    {
        general.SendMessage("error2FromBad");
    }

    public void Error3()
    {
        general.SendMessage("error3FromBad");
    }
}
