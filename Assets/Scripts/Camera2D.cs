using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Camera2D : MonoBehaviour
{
    public Transform targetPlayer;
    //public GameObject cameraTarget;

    // Update is called once per frame
    void Update()
    {
        /*Vector3 position= transform.position;
        position.x = cameraTarget.transform.position.x;
        transform.position  = position;*/
        transform.position = new Vector3(targetPlayer.position.x + 6f,0,-10);
    }
}
