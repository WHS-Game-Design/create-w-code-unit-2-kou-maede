using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private readonly float speed = 20f;
    private readonly int limitX = 15;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(inputX * speed * Vector3.right * Time.deltaTime);

        if(transform.position.x >= limitX)
        {
            transform.position = Vector3.right * limitX;
        }
        
        if(transform.position.x <= -limitX)
        {
            transform.position = Vector3.left * limitX;
        }
    }
}
