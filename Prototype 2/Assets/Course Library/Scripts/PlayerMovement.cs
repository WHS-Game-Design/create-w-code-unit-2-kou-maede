using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private readonly float speed = 30f;
    private readonly int limitX = 15;
    public GameObject projectilePrefab;
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
