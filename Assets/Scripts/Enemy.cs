﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float speed = 0;
	private Rigidbody rb;
	public RawImage hearts;
	public float life = 3;
	public float width ;
	public Text winText;

	// Use this for initialization
	void Start(){

		rb = GetComponent<Rigidbody>();
		width = 0.2f * life;
		hearts.uvRect = hearts.uvRect = new Rect(0.0f, 0.0f, width, 1.0f);



	}

	// Update is called once per frame
	void FixedUpdate(){

		float movementHorizontal = Random.Range (-1.0f, 1.0f);
		float movementVertical = Random.Range (-1.0f, 1.0f);

		Vector3 movement = new Vector3 (movementHorizontal, 0.0f, movementVertical);

		rb.AddForce (movement * speed);
	
	}

 	void OnCollisionEnter (Collision player){
		
	

		/* restituisce true se player ha tag Player */
		if (player.gameObject.CompareTag ("Player")) {

			/*controllo sulla variabile life per vedere se il player è ancora in vita*/
			if (life > 1) {

				UpdateHearts ();
							
			}else{
				life--;
				hearts.uvRect = hearts.uvRect = new Rect(0.0f, 0.0f, 0.2f *life, 1.0f);

				winText.text = "Hai perso!!!";	
				player.gameObject.SetActive (false); // controlla se l'oggetto è attivato

		}
	}
}
		
   public void UpdateHearts() {
		life--;
		hearts.uvRect = hearts.uvRect = new Rect(0.0f, 0.0f, 0.2f *life, 1.0f);
		hearts.SetNativeSize ();
	}
}
