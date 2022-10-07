using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToMenuLoader()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void MenutoCloudLoader()
    {
        SceneManager.LoadScene("CloudMoon", LoadSceneMode.Single);
    }

    public void MenutoFutureLoader()
    {
        SceneManager.LoadScene("FutureUpdates", LoadSceneMode.Single);
    }

    public void MenuToHowLoader()
    {
        SceneManager.LoadScene("HowToPlay", LoadSceneMode.Single);
    }
}

