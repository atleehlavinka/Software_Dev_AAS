using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public int maxHealth = 100;
    public int currentHealth;
    public int health = 3;
    public int gems = 0;
    public bool gameWon = false;
    public bool gameLost = false;

    public HealthBar healthBar;
    public Heart heart1;
    public Heart heart2;
    public Heart heart3;
    public Gem gem1;
    public Gem gem2;
    public Gem gem3;
    public GemBar gemBar;
    public HeartBar heartBar;
    public GameObject gameObj;
    public WinScreen winScreen;
    public LoseScreen loseScreen;
    public BloodPool bloodPool;
    public Shadow shadow;
    public Cat cat;
    public Door door;

    public MainLevel mainLevel;
    public HouseLevel houseLevel;

    public AudioSource mainTheme;
    public AudioSource gruntSound;
    public AudioSource dieSound;
    public AudioSource collectHeartSound;
    public AudioSource collectGemSound;
    public AudioSource woohooSound;
    public AudioSource boundarySound;
    public AudioSource walkSound;

    Vector2 movement;

    void Start()
    {
        Debug.Log("Starting game");
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        heartBar.SetHearts(health);
        gemBar.SetGems(gems);
        bloodPool.SetInactive();
        mainTheme.Play();

    }

    void Update()
    {
        if (gameLost == false && gameWon == false)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //if (animator.GetFloat("Speed") > 0 )
        //{
        //    walkSound.Play();
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(20);
        //}
        if (gameLost == false && gameWon == false && currentHealth <= 0)
        {
            //FindObjectOfType<LevelManager>().Restart();
            if (health > 1)
            {
                health = health - 1;
                heartBar.SetHearts(health);
                Respawn();
            }
            else
            {
                Lose();
            }
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void Lose()
    {
        Debug.Log("Lose screen displayed");
        health = health - 1;
        heartBar.SetHearts(health);
        mainTheme.Stop();
        dieSound.Play();
        loseScreen.SetActive();
        gameLost = true;
        healthBar.SetInactive();
        bloodPool.SetActive();
        shadow.SetInactive();
    }

    void TakeDamage(int damage)
    {
        if (!gameLost)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
            gruntSound.Play();
        }
    }

    void IncreaseHealth()
    {
        if (currentHealth < 100)
        {
            currentHealth = maxHealth;
            healthBar.SetHealth(maxHealth);
        }
    }

    void Respawn()
    {
        Debug.Log("Player ran out of health and has respawned");
        gameObj.transform.localPosition = new Vector2(0, 0);
        IncreaseHealth();
    }

    void DeactivateHeartObj(string heartName)
    {
        switch (heartName)
        {
            case "Heart1":
                Debug.Log("Heart1 set to inactive");
                heart1.SetInactive();
                break;
            case "Heart2":
                Debug.Log("Heart2 set to inactive");
                heart2.SetInactive();
                break;
            case "Heart3":
                Debug.Log("Heart3 set to inactive");
                heart3.SetInactive();
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            Debug.Log("Hit boundary");
            boundarySound.Play();
        }
        if (other.gameObject.tag == "Door")
        {
            Debug.Log("Entering house");
            door.Open();
            mainLevel.SetInactive();
            houseLevel.SetActive();

        }
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Player killed by enemy");
            TakeDamage(100);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        //if (other.gameObject.tag == "Door")
        //{
        //    door.Close();
        //}
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Leave")
        {
            Debug.Log("Leaving house");
            houseLevel.SetInactive();
            mainLevel.SetActive();
            door.Close();
        }
        
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("Player killed by enemy");
            //TakeDamage(100);

        }

        if (other.gameObject.tag == "Fire")
        {
            Debug.Log("Take 40 damage");
            TakeDamage(40);
        }
        if (other.gameObject.tag == "Cat")
        {
            cat.Sit();
        }
        if (other.gameObject.tag == "Heart")
        {
            Debug.Log("Heart detected");
            if (health < 3)
            {
                Debug.Log("Heart collected");
                health++;
                heartBar.SetHearts(health);
                collectHeartSound.Play();
                IncreaseHealth();
                DeactivateHeartObj(other.gameObject.name);
            }
            else if (currentHealth < 100)
            {
                Debug.Log("Back to full health");
                collectHeartSound.Play();
                IncreaseHealth();
                DeactivateHeartObj(other.gameObject.name);
            }
        }
        if (other.gameObject.tag == "Gem")
        {

            if (gems <= 3)
            {
                gems++;
                gemBar.SetGems(gems);
                Debug.Log("Gembar updated");
            }
            if (gems == 3)
            {
                Debug.Log("Win screen active");
                winScreen.SetActive();
                gameWon = true;
                mainTheme.Stop();
                woohooSound.PlayDelayed(1);
            }
            switch (other.gameObject.name)
            {
                case "Gem1":
                    Debug.Log("Collected GEM1");
                    gem1.SetInactive();
                    collectGemSound.Play();
                    break;
                case "Gem2":
                    Debug.Log("Collected GEM2");
                    gem2.SetInactive();
                    collectGemSound.Play();
                    break;
                case "Gem3":
                    Debug.Log("Collected GEM3");
                    gem3.SetInactive();
                    collectGemSound.Play();
                    break;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            cat.Stand();
        }
    }
}
