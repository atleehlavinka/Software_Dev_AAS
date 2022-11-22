using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Animator CatAnimation;
    public AudioSource Meow;

    public void Sit()
    {
        CatAnimation.SetBool("Sit", true);
        Meow.Play();
        Debug.Log("Cat is sitting and meowing");
    }
    public void Stand()
    {
        CatAnimation.SetBool("Sit", false);
        Debug.Log("Cat is standing");
    }
}
