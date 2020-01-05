using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform transform;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            transform.position = movement.startPosition;
        }
    }



}
