using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWin : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadWin(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadWin(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
