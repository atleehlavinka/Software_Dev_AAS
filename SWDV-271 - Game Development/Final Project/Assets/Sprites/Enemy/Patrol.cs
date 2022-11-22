using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Animator animator;
    public Transform[] waypoints;
    int current;
    public float speed;

    Vector2 movement;

    void Start()
    {
        current = 0;
    }
    void Update()
    {
        if (transform.position != waypoints[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].position, speed * Time.deltaTime);
            switch (current)
            {
                case 0:
                    animator.SetFloat("Horizontal", 1);
                    animator.SetFloat("Vertical", 0);
                    break;
                case 1:
                    animator.SetFloat("Horizontal", 0);
                    animator.SetFloat("Vertical", 1);
                    break;
                case 2:
                    animator.SetFloat("Horizontal", 0);
                    animator.SetFloat("Vertical", -1);
                    break;
                case 3:
                    animator.SetFloat("Horizontal", -1);
                    animator.SetFloat("Vertical", 0);
                    break;
            }

            
        } else
        {
            current = (current + 1) % waypoints.Length;
        }
        animator.SetFloat("Speed", 1);
    }
}
