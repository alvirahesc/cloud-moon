using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactibles : MonoBehaviour
{
    [SerializeField] private GameObject pressF;
    [SerializeField] private Transform hintPos;

    private GameObject clonePressF;

    
    private void Update()
    {
        //nanti kita ambil keydown, kita instantiate TEXT yang kita bikin public/serializedfield
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           clonePressF = Instantiate(pressF, hintPos);
           
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(clonePressF);
        }
    }
}
