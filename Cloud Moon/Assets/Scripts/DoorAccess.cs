using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAccess : MonoBehaviour
{
    [SerializeField] private Transform DoorDestination;

    public Transform GetDestination()
    {
        return DoorDestination;
    }
}
