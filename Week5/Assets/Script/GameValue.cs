using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameValue : MonoBehaviour
{
    public bool isFishermanEnable;
    public int fishermanLevel;
    public double fishNumber;
    public double moneyNumber;

    
    public GameObject fishNumberDisplay;
    public TMP_Text fishNumberText;
    public GameObject moneyNumberDisplay;
    public TMP_Text moneyNumberText;

    void Start()
    {
        isFishermanEnable = false;
        fishNumber = 0;
        moneyNumber = 100;
        fishermanLevel = 0;

        fishNumberText = fishNumberDisplay.GetComponent<TMP_Text>();
        moneyNumberText = moneyNumberDisplay.GetComponent<TMP_Text>();
    }

    void Update()
    {
        fishNumberText.text = fishNumber.ToString();
        moneyNumberText.text = moneyNumber.ToString();



    }
}
