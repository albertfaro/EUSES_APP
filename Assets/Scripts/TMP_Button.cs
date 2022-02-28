using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class TMP_Button : MonoBehaviour
{
    public GameObject button;
    public GameObject buttonText;
   
 
    private void Start()
    {
        
        string buttonName = button.name;
        string newText = AppManager.language.getString(buttonName);
        buttonText.GetComponent<TMP_Text>().text = newText;

    }
    private void Update()
    {
        string buttonName = button.name;
        string newText = AppManager.language.getString(buttonName);
        buttonText.GetComponent<TMP_Text>().text = newText;
    }
}
