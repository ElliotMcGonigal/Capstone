using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 12f;
    Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        player = GameObject.Find("Player").transform;
    }

    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);
        Vector3 fixedPos = new Vector3(pos.x, 0f, pos.z);
        rig.MovePosition(fixedPos);
        transform.LookAt(player);
    }
}
