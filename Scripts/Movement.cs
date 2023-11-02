using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform Offset;

    public Projectile ProjectilePrefab;

    public float speed = 0;
    
    // Start is called before the first frame update
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, Offset.position, transform.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            Destroy(this.gameObject);
            Debug.Log("loser");
        }
    }
}
