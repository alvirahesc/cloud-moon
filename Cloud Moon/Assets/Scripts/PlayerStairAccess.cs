
using UnityEngine;

public class PlayerStairAccess : MonoBehaviour
{
    private GameObject triggeredStairs;
    [SerializeField] private AudioSource stairSound;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (triggeredStairs != null)
            {
                transform.position = triggeredStairs.GetComponent<DoorAccess>().GetDestination().position;
                stairSound.Play();
                Instantiate(GetComponent<PlayerDoorAccess>().blackSquare, GetComponent<PlayerDoorAccess>().mainCam);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stair Trigger"))
        {
            triggeredStairs = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Stair Trigger"))
        {
            triggeredStairs = null;
        }
    }
}
