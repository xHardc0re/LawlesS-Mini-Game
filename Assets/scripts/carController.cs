using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

	public float carSpeed;
	Vector3 position;
	public UiManager ui;

	public trackMove trackMov;

    /// 
    /// KSEKINIMA APO THN ARXIKH THESH
    ///
    void Start () {
		InvokeRepeating ("StarSound",9f,12000f);
		position = transform.position;

	}

    /// 
    /// ANANEWSH THS THESHS TOU DIASTIMOPLOIOU
    ///
    void Update () {
		
		position.x  = position.x +Input.GetAxis ("Horizontal")*carSpeed *Time.deltaTime;

		position.x=Mathf.Clamp (position.x, -6.5f, 6.5f);
			transform.position=position;
		

	}

    /// 
    ///SIMVAINEI SE PERIPTOSH COLLISION
    ///
    void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
			ui.gameOver ();
			trackMov.speed = 0;
		}
	}
}
