using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator DoorAnimation;
    public AudioSource DoorOpenSound;
    public AudioSource DoorCloseSound;

    public bool closed = true;
    public bool opened = false;

    public void Open()
    {
        opened = true;
        closed = false;
        DoorOpenSound.Play();
    }
    public void Close()
    {
        DoorAnimation.SetBool("Opened", opened);
        DoorAnimation.SetBool("Close", opened);
        DoorCloseSound.Play();
        opened = false;
        closed = true;
    }
}
