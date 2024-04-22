using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public string sceneName;
    private Animator fadeSystem;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perso"))
        {
            StartCoroutine(loadNextScene());
        }
    }
    public IEnumerator loadNextScene()
    {
        //LoadAndSaveData.instance.SaveData();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}