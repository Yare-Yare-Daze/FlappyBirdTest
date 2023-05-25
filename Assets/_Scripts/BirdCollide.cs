using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollide : MonoBehaviour
{
    public Action OnCollidedObstacle;
    public Action OnTriggeredScore;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Strings.tagObstacle))
        {
            OnCollidedObstacle?.Invoke();
            Time.timeScale = 0.0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Strings.tagScoreTrigger))
        {
            OnTriggeredScore?.Invoke();
        }
    }
}
