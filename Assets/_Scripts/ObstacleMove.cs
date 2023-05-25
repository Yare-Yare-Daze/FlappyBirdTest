using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float startSpawnXPosition;
    [SerializeField] private float coordXForRespawn;
    [SerializeField] private Vector2 minMaxYRange;

    private void Update()
    {
        Move();

        CheckPositionForRespawn();
    }

    private void Move()
    {
        var tempPos = transform.position;
        tempPos.x += -moveSpeed * Time.deltaTime;
        transform.position = tempPos;
    }

    private void CheckPositionForRespawn()
    {
        if(transform.position.x < coordXForRespawn)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        var randomYPosition = Random.Range(minMaxYRange.x, minMaxYRange.y);

        transform.position = new Vector3(startSpawnXPosition, randomYPosition, transform.position.z);

    }
}
