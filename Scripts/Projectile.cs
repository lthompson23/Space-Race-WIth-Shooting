using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0;

    public float lifetime;

    public float lifetimeCounter;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed; 

        lifetimeCounter += Time.deltaTime;

        if (lifetimeCounter > lifetime)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
