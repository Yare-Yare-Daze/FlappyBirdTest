using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private Rigidbody2D rigbody2D;
    [SerializeField] private float forceUpImpulse;

    private void Awake()
    {
        playerInput.OnTouched += OnTouchedHandler;
    }

    private void OnTouchedHandler()
    {
        rigbody2D.velocity = Vector2.zero;
        rigbody2D.AddForce(Vector2.up * forceUpImpulse, ForceMode2D.Impulse);
    }
}
