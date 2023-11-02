using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movement : MonoBehaviour
{
    public UnityEngine.Transform Offset;

    public Projectile ProjectilePrefab;

    public float speed = 0;

    public float fireRate;

    AudioSource m_shootingSound;

    float fireCooldown;

    // Start is called before the first frame update
    void Start()
    {
        fireCooldown = fireRate;
        m_shootingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float moveAmount = moveInput * speed * Time.deltaTime;

        // Move the player up or down
        transform.Translate(0, moveAmount, 0);

        fireCooldown += Time.deltaTime;
        
        if (fireCooldown >= fireRate
            //If the game is not paused
            && PauseMenu.isPaused == false
            //&& !PauseMenuScript.isPaused
            //If the player is pressing the shoot button
            && Input.GetKeyDown(KeyCode.Space))
        //&& Input.GetButton(shootButton))
        //&& Input.GetButtonUp(shootButton))
        {
            //Call the Shoot function 
            Shoot();

            //Reset the cooldown
            fireCooldown = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            Destroy(this.gameObject);
            Debug.Log("loser");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
                {
                    Instantiate(ProjectilePrefab, Offset.position, transform.rotation);
                    m_shootingSound.Play();
                }
    }
        
}
