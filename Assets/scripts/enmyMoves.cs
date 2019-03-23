using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmyMoves : MonoBehaviour {

	public float speed=5f;
	void Start () {
		
	}

    /// 
    /// KATEBENOUN PROS TA KATW TA ENEMY OBJECTS ANA FRAME ME TAXITITA 5F
    ///
    void Update () {
		transform.Translate (new Vector3 (0, 1,0) * 	speed * Time.deltaTime);
	}
}
