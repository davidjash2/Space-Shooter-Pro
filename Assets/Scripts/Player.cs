using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public or private reference
    // Data Type ( int, float, bool, string)
    // Every variable has a name
    // Optional value assigned
    [SerializeField]
    private float _speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Take the current position = new.position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        // if palyer position on the y is greater than 0
        // y positon = 0
        // else if position on the y is less than -3.8f
        // y pos = -3.8f

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }

        // if player on the x > 11
        // x pos = -11
        // else if player on the x is less than -11
        // x pos = 11
        if(transform.position.x >= 11.0f)
        {
            transform.position = new Vector3(-11, transform.position.y, 0);
        }
        else if(transform.position.x < -11.0f)
        {
            transform.position = new Vector3(11, transform.position.y, 0);
        }
    }
}
