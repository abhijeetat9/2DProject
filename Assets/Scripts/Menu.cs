using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public float time = 0.3f;
    public void StartFirstLevel()
    {
        SceneManager.LoadScene(0);
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
