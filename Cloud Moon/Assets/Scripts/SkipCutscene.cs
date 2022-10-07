using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipCutscene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Skipped");
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
