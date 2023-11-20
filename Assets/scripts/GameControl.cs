using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class GameControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private FloatingJoystick joystick;

    GameObject fireControl;
    public float speed = 2.0f;


    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        rb.velocity = new Vector2(joystick.Horizontal *  speed, joystick.Vertical * speed);
    }


    private void moveCircle()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }


}
