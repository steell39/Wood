using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public GameObject woodText;
    public GameObject moneyText;


    public static int woodNumber = 0;
    public static int moneyNumber = 0;

    public int addWood = 1;



    //////////////////////////////////////////
    void Update()
    {
        woodText.GetComponent<Text>().text = "Wood: " + woodNumber;
        moneyText.GetComponent<Text>().text = "Coins: " + moneyNumber;
    }

    public void Chop()
    {
        woodNumber += addWood;
    }

}