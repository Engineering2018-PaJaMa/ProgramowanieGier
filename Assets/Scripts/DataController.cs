using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    public static int playerHp=3;
    public static int premiumMoney;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addHp()
    {
        if(premiumMoney>0)
        {
            playerHp += 1;
            premiumMoney -= 10;
            Debug.Log("Added life. Hp:"+playerHp+" Money:" +premiumMoney);
        }
        else
        {
            Debug.Log("No money");
        }
    }

    public void loseHp()
    {
        playerHp -= 10;
    }

}
