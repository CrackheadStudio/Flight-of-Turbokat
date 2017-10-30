using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	public void LoadLevel(string sceneName)
    {
        StartCoroutine(LoadAsync(sceneName));

    }

    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while(operation.isDone == false)
        {
            Debug.Log(operation.progress);
            yield return null;
        }
    }
}
