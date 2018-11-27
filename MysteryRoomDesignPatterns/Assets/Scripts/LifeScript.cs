﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeScript : MonoBehaviour {

    public Text LifeText;

    public Text DisplayText;

    private static int life = 3;

    public string newLevel ;
    public string MenuScene="";

    int counter = 0;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
         LifeText.text = "Life : " + life;

        if (life <= 0)
        {
            DisplayText.text = "GAME OVER!!!";
            counter += 1;
            if(counter >= 200)
            SceneManager.LoadScene(MenuScene);
        }

    }

    void WrongClick()
    {
        if(life>0)
        life = life - 1;
    }

    void RightClick()
    {
        SceneManager.LoadScene(newLevel);
    }
}