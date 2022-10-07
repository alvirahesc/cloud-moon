using UnityEngine;


public class PlayerDoorAccess : MonoBehaviour
{
    private GameObject triggeredDoor;
    public Transform mainCam;
    public GameObject blackSquare;


    [SerializeField] private AudioSource openSound;
    


    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(triggeredDoor != null)
            {
                transform.position = triggeredDoor.GetComponent<DoorAccess>().GetDestination().position;
                openSound.Play();
                Instantiate(blackSquare, mainCam);
                
            }
        }   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door Trigger"))
        {
            triggeredDoor = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Door Trigger"))
        {
            triggeredDoor = null;
        }
    }

}
