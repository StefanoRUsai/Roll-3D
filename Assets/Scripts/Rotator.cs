using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //mettiamo qui la rotazione perchè il tutto è legato al motore grafico, e non alla fisica

        //accedo al trasform del mio oggetto (deltatime=tempo passato dall'ultimo frame)
        transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
	}
}
