using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class start : MonoBehaviour
{
    public Slider slider;
    public GameObject loadingScreenObj;

    AsyncOperation async;

    //dikasih local variable LVL biar bisa tinggal kasih nomor scene yang mau di load
    public void LoadScene()
    {
        StartCoroutine(LoadingScreen());
    }

    //disini juga sama dengan di atas
    IEnumerator LoadingScreen()
    {
        loadingScreenObj.SetActive(true);
        async = SceneManager.LoadSceneAsync("Intro");
        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            slider.value = async.progress;
            if(async.progress == 0.9f)
            {
                slider.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
        
    public void ExitApp()
    {
        Application.Quit();
        //Debug.Log("Application Terminated");
    }
   
}
