using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMove : MonoBehaviour {

	public float speed ;
	 Vector2 offset;
	void Start () {
		InvokeRepeating ("setSpeed",9f,12000f);
	}

    /// 
    /// KANEI TH STATIC IMAGE ME TO DIASTIMA NA KATEBENEI SINEXEIA OSTE NA DINEI THN AISTHISI THS KINHSHS
    ///
    void Update () {
		offset = new Vector2 (0, Time.time * speed);

		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}

	void setSpeed(){
		speed = 2;
	}

}
