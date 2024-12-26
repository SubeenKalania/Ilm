using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    const string homeScene= "Home" ;
    const string displayName = "DisplayNamesPage";
    public void LoadHomeScene()
    {

        SceneManager.LoadScene(homeScene);
    }

    public void LoadDisplayNames()
    {
        SceneManager.LoadScene(displayName);
    }
}
