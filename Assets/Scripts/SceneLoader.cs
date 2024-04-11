using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadSolarSystemScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadIntroScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadSolarEclipseScene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLunarEclipseScene()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadSeasonOnEarthScene()
    {
        SceneManager.LoadScene(4);
    }
}
