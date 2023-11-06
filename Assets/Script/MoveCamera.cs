using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CREDITS FOR FIRST PERSON GO TO https://www.youtube.com/watch?v=f473C43s8nE

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
