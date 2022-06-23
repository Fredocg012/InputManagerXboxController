using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Transform button_A;
    [SerializeField] Transform button_B;
    [SerializeField] Transform button_X;
    [SerializeField] Transform button_Y;


    Vector3 scaled = Vector3.one * 2f;
    Vector3 unscaled = Vector3.one * 1.8f;

    void Start()
    {
        
    }

    
    void Update()
    {
        button_A.localScale = Input.GetKey(KeyCode.Joystick1Button0) ? scaled : unscaled;
        button_B.localScale = Input.GetKey(KeyCode.Joystick1Button1) ? scaled : unscaled;
        button_X.localScale = Input.GetKey(KeyCode.Joystick1Button2) ? scaled : unscaled;
        button_Y.localScale = Input.GetKey(KeyCode.Joystick1Button3) ? scaled : unscaled;
    }
}
