using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemBar : MonoBehaviour
{
    public int numOfGems; //3

    public Image[] gemImages;
    public Sprite fullGem;
    public Sprite emptyGem;

    public void SetGems(int gems)
    {
        if (gems > numOfGems)
        {
            gems = numOfGems;
        }

        for (int i = 0; i < gemImages.Length; i++)
        {
            if (i < gems)
            {
                gemImages[i].sprite = fullGem;
            }
            else
            {
                gemImages[i].sprite = emptyGem;
            }
            if (i < numOfGems)
            {
                gemImages[i].enabled = true;
            }
            else
            {
                gemImages[i].enabled = false;
            }
        }
    }
}
