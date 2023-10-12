using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0; 


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float moveAmount = moveInput * speed * Time.deltaTime;

        // Move the player up or down
        transform.Translate(0, moveAmount, 0);
    }
}
