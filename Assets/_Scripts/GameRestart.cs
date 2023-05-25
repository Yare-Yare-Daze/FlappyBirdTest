using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRestart : MonoBehaviour
{
    [SerializeField] private BirdCollide birdCollide;

    private void Awake()
    {
        birdCollide.OnCollidedObstacle += OnCollidedObstacleHandler;
    }

    private void OnCollidedObstacleHandler()
    {

    }
}
