using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    private void Start()
    {
        moveSpeed = Random.Range(1, 2);
    }
    private void Update()
    {

        Vector3 playerPos = GameObject.Find("Player").transform.position;
        if (Vector2.Distance(transform.position, playerPos) > .3f)
            transform.position = Vector3.MoveTowards(transform.position, playerPos, moveSpeed * Time.deltaTime);
    }
}
