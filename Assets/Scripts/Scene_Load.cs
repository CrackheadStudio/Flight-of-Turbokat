using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Load : MonoBehaviour {
    public GameObject loadingScreen, currentScreen;
    public Slider slider;
	
	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Single);
		Time.timeScale = 1;
        StartCoroutine(LoadAsync(SceneName));
    }

    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);
        currentScreen.SetActive(false);
        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }
}
