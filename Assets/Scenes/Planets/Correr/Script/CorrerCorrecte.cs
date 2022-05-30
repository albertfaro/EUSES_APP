﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrerCorrecte : MonoBehaviour
{
    Animator anim;
    public GameObject general;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(anim.GetCurrentAnimatorStateInfo(0).IsName("Correr") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            anim.SetTrigger("AnimationFinished");
            Debug.Log("FINISHED!");
            general.SendMessage("finishedCorrectRun");
        }
    
    }



    public void buttonPressed()
    {
        anim.SetTrigger("ButtonPressed");
        Debug.Log("ANIM");
    }


    

}
