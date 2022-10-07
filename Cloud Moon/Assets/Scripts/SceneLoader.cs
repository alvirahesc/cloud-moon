using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int scene;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }        
}
