using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        Invoke("LoadFirstScene", 3f);
    }
    // Update is called once per frame
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
