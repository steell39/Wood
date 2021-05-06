using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CuttingScript : MonoBehaviour
{

    public bool cuttingWood = false;
    public int aut_wood = 1;




    int w_number;
    int curEnergy;
    public int addWood = 1;
    void Update()
    {
        if (cuttingWood == false)
        {
            cuttingWood = true;
            StartCoroutine(PlusTheWood());
        }
    }

    IEnumerator PlusTheWood()
    {
        GameScript.woodNumber += aut_wood;
        yield return new WaitForSeconds(3);
        cuttingWood = false;
    }

    public void Chop()
    {
        curEnergy = Energycript.currentEnergy;
        if (curEnergy > 0)
        {
            w_number = GameScript.woodNumber += addWood;
        }
    }


}
