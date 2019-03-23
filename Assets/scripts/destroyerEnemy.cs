using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerEnemy : MonoBehaviour {


    /// 
    /// KATASTREFEI TA ENEMY OBJECTS OTAN PERASOUN ENA WRIO KATW APO TH MAIN SCENE
    ///
    void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (col.gameObject);
		}
	}
}
