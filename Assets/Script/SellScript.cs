using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellScript : MonoBehaviour
{


    public int wood;
    public int s_wood = -1;

    public int coin;
    public int addMoney = 1;

    public GameObject wood_text;
    public GameObject coin_text;

    // Update is called once per frame
    void Update()
    {
        wood = GameScript.woodNumber;
        wood_text.GetComponent<Text>().text = "Wood: " + wood;

        coin = GameScript.moneyNumber;
        coin_text.GetComponent<Text>().text = "Coin: " + coin;

    }
    public void Sell()
    {

        if (wood > 0)
        {
            wood = GameScript.woodNumber += s_wood;
            coin = GameScript.moneyNumber += addMoney;
        }

    }

}



