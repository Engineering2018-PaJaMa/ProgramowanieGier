using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataController : MonoBehaviour {

    public static int playerHp=3;
    public static int premiumMoney;
    public Text livesToSHow;
    public Text moneyToShow;
    // Use this for initialization
    void Start () {
        livesToSHow.text = "Lives:" + playerHp;
        moneyToShow.text = "Money:" + premiumMoney;
    }
	
	// Update is called once per frame
	void Update () {
        if(livesToSHow != null && moneyToShow != null)
        {
            livesToSHow.text = "Lives:" + playerHp;
            moneyToShow.text = "Money:" + premiumMoney;
        }
    }

    public void addHp()
    {
        if(premiumMoney>0)
        {
            playerHp += 1;
            premiumMoney -= 10;
            Debug.Log("Added life. Hp:"+playerHp+" Money:" +premiumMoney);
            livesToSHow.text = "Lives:" + playerHp;
        }
        else
        {
            Debug.Log("No money");
        }
    }

    public void loseHp()
    {
        playerHp -= 1;
        livesToSHow.text = "Lives:" + playerHp;
    }

}
