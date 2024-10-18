using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;

    void Update()
    {
        coinDisplay.GetComponent<TMP_Text>().text = "Coins : " + coinCount;
    }
}
