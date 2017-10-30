using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Importo la mia UI


public class GameController : MonoBehaviour
{
	public Text countText;
	public Text winText;
	private int count;

	void Start (){
		count = 0;
		UpdateText();
	}

	void Update (){
		UpdateText ();	
	}


	public void AddScore ()
	{
		count++;
		UpdateText ();
	}


	public void UpdateText(){
		if(count == 14){
			countText.text = "Score" + count;
			winText.text = "Hai vinto !!!";	

		}else{
			countText.text = "Score" + count;

		}    
	}


}