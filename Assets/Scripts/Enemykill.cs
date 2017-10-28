using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision enemy){
		if (enemy.gameObject.CompareTag("Enemy"))  //restituisce true enemy ha tag pickup 
			enemy.gameObject.SetActive(false); // controlla se l'oggetto è attivato
	}
}
