using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int splashScreenLoadTime = 3;

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            LoadStartSceneFromSplashScene();
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadLoseScene()
    {
        SceneManager.LoadScene("Lose Scene");
    }

    private IEnumerator DelayNextScene(int sceneNumber, int seconds = 0)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneNumber);
    }

    private IEnumerator DelayNextScene(string sceneName, int seconds = 0)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneName);
    }

    private void LoadStartSceneFromSplashScene()
    {
        StartCoroutine(DelayNextScene(1, splashScreenLoadTime));
    }
}
