using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
    Vector3 originalPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            gameObject.transform.position = originalPos;
            Plus.score += 5;
            Debug.Log("score +10");
        }
    }



}
