using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    
    void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Enemy") {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
