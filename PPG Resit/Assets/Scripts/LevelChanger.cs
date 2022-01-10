using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator animator;
    
    private int levelToLoad;

    private Scene scene;


    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    public void NextScene()
    {
        FadeToLevel();
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
        
    }

    public void OnFadeComplete()
    {
        int nextSceneIndex = scene.buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
        Debug.Log(nextSceneIndex);
    }
}
