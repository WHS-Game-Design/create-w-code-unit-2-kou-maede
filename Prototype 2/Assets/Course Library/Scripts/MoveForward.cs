using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Don't make variables up here.

public class MoveForward : MonoBehaviour
{
    private float speed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);        
    }
}
