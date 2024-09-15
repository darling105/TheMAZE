using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public CoinCollectTask coinCollectTask;
    public GameObject door;
    public float doorOpenDuration = 2f;
    public Vector3 doorOpenVector = new Vector3(0f, -0.5f, 0f);

    private bool isOpening = false;
    private bool isFullyOpen = false;
    private float openStartTime = 0;
    private Vector3 doorStartPosition;

    private void Start() {
        doorStartPosition = door.transform.position;
    }

    void Update() {
        if (isOpening) {
            
            float openTimeElapsed = Time.time - openStartTime;

            if (openTimeElapsed <= doorOpenDuration) {
                float doorProgress = openTimeElapsed / doorOpenDuration;
                door.transform.position = doorStartPosition + doorOpenVector * doorProgress;
            }
            else {
                door.transform.position = doorStartPosition + doorOpenVector;
                isOpening = false;
                isFullyOpen = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Player") && !isFullyOpen && coinCollectTask.allCoinsCollected && !isOpening) {
            isOpening = true;
            openStartTime = Time.time;
        }

    }

}
