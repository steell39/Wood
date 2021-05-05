using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingScript : MonoBehaviour
{

    int w_number;
    int curEnergy;
    public int addWood = 1;

    public void Chop()
    {
        curEnergy = Energycript.currentEnergy;
        if (curEnergy > 0)
        {
            w_number = GameScript.woodNumber += addWood;
        }

    }
}
