using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator animator;
    
    private int levelToLoad;

    // Update is called once per frame
    public void NextScene()
    {
        FadeToLevel(0);
    }

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        if (levelToLoad < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(levelToLoad + 1);
        else
        {
            SceneManager.LoadScene(levelToLoad + 1);
        }
    }
}
