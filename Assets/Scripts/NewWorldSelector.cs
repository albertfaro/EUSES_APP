using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewWorldSelector : MonoBehaviour
{
    public List<GameObject> planets;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextPlanet()
    {

    }


    public void previousPlanet()
    {

    }

    public void getToPlanet(string planetName)
    {
        SceneManager.LoadScene(planetName);
    }
}
