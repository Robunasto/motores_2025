using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform transform;
    public float _speed = 2f;
    public float maxAcceleration = 3f;
    public float accelerationRate = 0.025f;
    public float decelerationRate = 0.05f;

    private float acceleration = 0f;
    private void Awake()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            acceleration += accelerationRate;
            if (acceleration >= maxAcceleration) {
                acceleration = maxAcceleration;
            }
            else
            {
                acceleration -= decelerationRate;
                if (acceleration < 1f)
                {
                    acceleration = 1f;
                }
            }
        }

        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, _speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0f, _speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(_speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(_speed * Time.deltaTime, 0f, 0f);
        }
        */



        /*

        float timeSpeed = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position = new Vector3(transform.position.x, transform.position.y + _speed, transform.position.z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - _speed, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - _speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(transform.position.x + _speed, transform.position.y, transform.position.z);
        }
        //*/
    }
}
