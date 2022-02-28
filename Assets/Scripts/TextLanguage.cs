using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextLanguage : MonoBehaviour
{
    public GameObject textCamp;
    public GameObject Ttext;


    private void Start()
    {

        string tcName = textCamp.name;
        string newText = AppManager.language.getString(tcName);
        Ttext.GetComponent<TMP_Text>().text = newText;

    }
    private void Update()
    {
        string tcName = textCamp.name;
        string newText = AppManager.language.getString(tcName);
        Ttext.GetComponent<TMP_Text>().text = newText;
    }
}
