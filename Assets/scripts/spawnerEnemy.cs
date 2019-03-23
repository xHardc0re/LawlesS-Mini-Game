﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemy : MonoBehaviour {

	public GameObject []cars;
	int num;
	public float delayTime=0.5f;
	float timer;

	void Start () {
		timer = delayTime;
		InvokeRepeating ("DelayTimeHard",60f,1200f);
		InvokeRepeating ("DelayTimeHard1",130f,1200f);
	}

    /// 
    /// KANEI SPAWN SE TIXAIA THESEI APO 0 EWS 8 OBJECTS
    ///
    void Update () {
		timer = timer - Time.deltaTime;
		if (timer <= 0) {
			
			Vector3 pos = new Vector3 (Random.Range (-6.05f, 6.05f), transform.position.y, 
				             transform.position.z);
			num = Random.Range (0, 8);
			Instantiate (cars[num], pos, transform.rotation);

			timer = delayTime;
		
		}
	}
	public void DelayTimeHard(){
		delayTime=0.6f;
	}
	public void DelayTimeHard1(){
		delayTime=0.5f;
	}
}
