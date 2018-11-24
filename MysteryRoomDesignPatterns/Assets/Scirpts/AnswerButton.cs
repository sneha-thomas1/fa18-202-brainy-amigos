﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour {

    public Text answerText;
    private AnswerData answerData;

	// Use this for initialization
	void Start () {
		
	}

    public void SetUp(AnswerData data) {
        answerData = data;
        Debug.Log(answerData.answerText);
        answerText.text = answerData.answerText;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
