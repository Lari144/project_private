using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneDelay : MonoBehaviour
{
    public void ButtonFunction()
    {
        StartCoroutine(DelaySceneLoad());
    }
     
    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
