using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerCore : MonoBehaviour
{

    [SerializeField] private GameObject ClickerMain;
    //get the canvas button gameobjects to check if clicked
    [SerializeField] private GameObject BTN1;
    [SerializeField] private GameObject BTN2;
    [SerializeField] private GameObject BTN3;
    [SerializeField] private GameObject Money;

    public int money = 0;
    public int clicknumber = 1;

    public bool BTN2Effect = false;
    public bool BTN3Effect = false;
    public float time = 0f;
    public float time2 = 0f;

    // Update is called once per frame
    void Update()
    {
        //set money text to the current money textmeshpro
        Money.GetComponent<TMPro.TextMeshProUGUI>().text = money.ToString();

        //if clicker add 1 to money
        if (Input.GetMouseButtonDown(0))
        {
            money += clicknumber;
        }

        //get the btn1 position and check if clicked
        Vector3 BTN1Pos = Camera.main.WorldToScreenPoint(BTN1.transform.position);
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x > BTN1Pos.x - 125 && Input.mousePosition.x < BTN1Pos.x + 125 && Input.mousePosition.y > BTN1Pos.y - 15 && Input.mousePosition.y < BTN1Pos.y + 15)
        {
            Debug.Log("BTN1 Clicked");
            //add 1 to clicknumber
            clicknumber += 1;
        }

        //get the btn2 position and check if clicked
        Vector3 BTN2Pos = Camera.main.WorldToScreenPoint(BTN2.transform.position);
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x > BTN2Pos.x - 125 && Input.mousePosition.x < BTN2Pos.x + 125 && Input.mousePosition.y > BTN2Pos.y - 15 && Input.mousePosition.y < BTN2Pos.y + 15)
        {
            Debug.Log("BTN2 Clicked");
            // add 1 each second to money
            BTN2Effect = true;
        }

        //get the btn3 position and check if clicked
        Vector3 BTN3Pos = Camera.main.WorldToScreenPoint(BTN3.transform.position);
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x > BTN3Pos.x - 125 && Input.mousePosition.x < BTN3Pos.x + 125 && Input.mousePosition.y > BTN3Pos.y - 15 && Input.mousePosition.y < BTN3Pos.y + 15)
        {
            Debug.Log("BTN3 Clicked");
            BTN3Effect = true;
        }

        if (BTN2Effect == true)
        {
            //add 1 each second to money
            time += Time.deltaTime;
            if (time >= 1f)
            {
                money += 1;
                time = 0f;
            }
        }

        if (BTN3Effect == true)
        {
            //add 1 each second to money
            time2 += Time.deltaTime;
            Debug.Log(time);
            if (time2 >= 15f)
            {
                money += 10;
                time2 = 0f;
            }
        }

    }
}
