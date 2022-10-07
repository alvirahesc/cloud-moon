using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjective : MonoBehaviour
{
    [SerializeField] private GameObject objectives;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            objectives.gameObject.SetActive(true);
        }

        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            objectives.gameObject.SetActive(false);
        }

    }
}
