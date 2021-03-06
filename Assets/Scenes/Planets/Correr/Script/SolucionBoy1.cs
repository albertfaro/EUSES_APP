using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolucionBoy1 : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Correr") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            anim.SetTrigger("AnimationFinished");
            //Animación terminada
        }
    }

    public void activateAnim()
    {
        //Animación activada
        anim.SetTrigger("ButtonPressed");
    }
}
