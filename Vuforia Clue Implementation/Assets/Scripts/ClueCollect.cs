using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueCollect : MonoBehaviour
{

    public GameObject Clue1;
    public GameObject Clue2;
    public GameObject Clue3;

    public TextMeshProUGUI clueText;
    public int amountOfClues = 0;

    public static bool collected1 = false;
    public static bool collected2 = false;
    public static bool collected3 = false;

   
    // Update is called once per frame
    void Update()
    {
        

        if (collected1 == false) //Clue 1's Conditional
        {
            Clue1.SetActive(true);
        } else
        {
            Clue1.SetActive(false);
        }

        if (collected2 == false) //Clue 2's Conditional
        {
            Clue2.SetActive(true);
        }
        else
        {
            Clue2.SetActive(false);
        }

        if (collected3 == false) //Clue 3's Conditional
        {
            Clue3.SetActive(true);
        }
        else
        {
            Clue3.SetActive(false);
        }

        
    }

    public void CollectClue1()
    {
        collected1 = true;
        if (amountOfClues == 3)
        {
            amountOfClues = 3;
            clueText.text = amountOfClues.ToString();
        }
        else
        {
            amountOfClues += 1;
            clueText.text = amountOfClues.ToString();
        }
    }

    public void CollectClue2()
    {
        collected2 = true;

        if (amountOfClues == 3)
        {
            amountOfClues = 3;
            clueText.text = amountOfClues.ToString();
        }
        else
        {
            amountOfClues += 1;
            clueText.text = amountOfClues.ToString();
        }

    }

    public void CollectClue3()
    {
        collected3 = true;

        if (amountOfClues == 3)
        {
            amountOfClues = 3;
            clueText.text = amountOfClues.ToString();
        }
        else
        {
            amountOfClues += 1;
            clueText.text = amountOfClues.ToString();
        }
    }
}
