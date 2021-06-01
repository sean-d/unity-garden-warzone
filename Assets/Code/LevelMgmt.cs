using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMgmt : MonoBehaviour
{
    [SerializeField] int waitingTimeToLoadStartScreen = 4;
    int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            StartCoroutine(waitToLoadStartScene());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitToLoadStartScene()
    {
        yield return new WaitForSeconds(waitingTimeToLoadStartScreen);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
