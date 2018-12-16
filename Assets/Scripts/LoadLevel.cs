using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LevelLoader(string levelName)
    {
        if(DataController.playerHp > 0)
        {
            SceneManager.LoadScene(levelName);
        }
        else
        {
            Debug.Log("No HP");
        }
    }
}
