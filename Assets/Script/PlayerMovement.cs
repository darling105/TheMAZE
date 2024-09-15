using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private CapsuleCollider capsuleCollider;
    public float moveSpeed = 5;

    public float ForwardInput { get; set;}
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    private void FixedUpdate() {
        Movement();
    }
    private void Movement() 
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        rigidbody.MovePosition(transform.position + input * Time.deltaTime * moveSpeed);
    }
}
