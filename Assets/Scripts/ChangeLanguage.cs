using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
public class ChangeLanguage : MonoBehaviour
{
    public TextMeshProUGUI output;

   public void HandleInputData(int val)
    {
        if(val == 0)
        {
            AppManager.language.setLanguage(Path.Combine(Application.dataPath, "lang.xml"), "English");
        }

        if (val == 1)
        {
            AppManager.language.setLanguage(Path.Combine(Application.dataPath, "lang.xml"), "Spanish");
        }

        if (val == 2)
        {
            AppManager.language.setLanguage(Path.Combine(Application.dataPath, "lang.xml"), "Catalan");
        }

    }
}
