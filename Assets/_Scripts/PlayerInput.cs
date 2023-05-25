using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Action OnTouched;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            
            if(touch.phase == TouchPhase.Began )
            {
                OnTouched?.Invoke();
            }
        }
    }
}
