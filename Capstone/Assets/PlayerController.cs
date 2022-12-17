using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Header("References")]
    public Rigidbody player;
    public Transform head;
    public Camera camera;

    [Header("Configurations")]
    public float walkSpeed;
    public float runSpeed;

    [Header("Runtime")]
    Vector3 newVelocity;

    void Update() {
        newVelocity = Vector3.up * player.velocity.y;
        float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        newVelocity.x = Input.GetAxis("Horizontal") * speed;
        newVelocity.z = Input.GetAxis("Vertical") * speed;

        player.velocity = transform.TransformDirection(newVelocity);
    }
}