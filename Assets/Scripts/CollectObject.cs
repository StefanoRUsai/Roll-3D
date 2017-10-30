using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Importo la mia UI

public class CollectObject : MonoBehaviour {

    //public int count=0; //contatore degli oggetti colpiti (public per farla aggiornare nell'editor)
   // public Text countText;
    //public Text winText;
	public GameController game;
	// Use this for initialization
	void Start(){
        //UpdateText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*Funzione per il player che gli permette di collidere con il cubo e di disattivarlo*/
    void OnTriggerEnter(Collider other){

		/*gameobject è salvato in un attributo di other, che è di tipo collider*/
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false); //SetActice permette di attivare o meno l'oggetto
			game.AddScore ();
			/*	if (count <= 14) { 
				count++;
			}
            UpdateText();    
        }*/
		}
	}

	/*public void UpdateText(){
		if(count == 14){
			countText.text = "Score" + count;
		 	winText.text = "Hai vinto !!!";	

		}else{
			countText.text = "Score" + count;

		}    
	}*/
}
