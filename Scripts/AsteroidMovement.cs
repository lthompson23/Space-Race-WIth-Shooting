using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 10;

    public float lifetime;

    public float lifetimeCounter = 0;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;

        //We use the function (to keep update clean)


        //The deltatime is added to the counter
        lifetimeCounter += Time.deltaTime;

        //If the counter has exceeded the lifetime
        if (lifetimeCounter > lifetime)
        {
            //Destroy this
            Destroy(this.gameObject);
        }




    }
}