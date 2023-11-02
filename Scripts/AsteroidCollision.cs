using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{

    AudioSource m_explosion;

    private void Start()
    {
        m_explosion = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Plus.score += 1;
            m_explosion.Play();
        }
    }
}
