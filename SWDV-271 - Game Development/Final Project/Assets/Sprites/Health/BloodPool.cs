using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodPool : MonoBehaviour
{
    public void SetActive()
    {
        gameObject.SetActive(true);
    }

    public void SetInactive()
    {
        gameObject.SetActive(false);
    }

    public void CheckActive(int health)
    {
        if (health > 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
