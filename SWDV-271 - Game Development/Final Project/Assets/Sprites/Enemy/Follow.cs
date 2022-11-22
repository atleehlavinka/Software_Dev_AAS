using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public Transform[] waypoint;
    public float moveSpeed;
    private Rigidbody2D rb;
    public Animator animator;
    private bool dangerZone = false;

    private Vector2 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (dangerZone)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
        else
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
            Vector3 direction = waypoint[0].position - transform.position;
            direction.Normalize();
            movement = direction;
            //transform.position = Vector3.MoveTowards(transform.position, waypoint[0].position, moveSpeed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy chasing player");
            dangerZone = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy returning to waypoint");
            dangerZone = false;
        }
    }
}
