using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
public class AppManager : MonoBehaviour
{
    public static AppManager Instance { get; private set; }
    public static XmlDocument xmldoc = new XmlDocument();
    public static Lang language;
    public static string path;
    
    private void Awake()
    {

        language = new Lang(path, "English", false);
        path = Path.Combine(Application.dataPath, "lang.xml");

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Debug.Log("Warning: multiple " + this + " in scene!");
        }
    }

    public User_Model currentUser;
    public Profile_Model currentProfile;
    

    private void Start()
    {
        
        TextAsset textAsset = (TextAsset)Resources.Load("Languages", typeof(TextAsset));
        //xmldoc.LoadXml(textAsset.text);
    }


}
