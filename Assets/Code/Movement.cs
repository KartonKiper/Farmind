using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = .1f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(-x, 0.0f, y);

        transform.position += move * speed;
     
    }
}
