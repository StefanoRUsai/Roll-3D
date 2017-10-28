using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed=10;
    public float jumpIntesity; //valore che determina la forza del salto
    private Rigidbody rb;
    private bool isOnGround=true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); //recupero il rigid body dell'oggetto (<> perchè è un generic)
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate(){ //lo usiamo per far si che la fisica sia indipendente dal framerate (metodo update)

        float moveHorizontal = Input.GetAxis("Horizontal"); //horizontal e vertical sono tipo keywords
        float moveVertical = Input.GetAxis("Vertical"); //restituiscono un numero da -1 a 1 (avanti o indietro)

        //classe di tipo vettore (3d)
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //Vector3(x,y,z)

        rb.AddForce(movement * speed); //aggiungo una forza al rigidbody (solo con movement si muoverebbe con la forza minima...quindi moltiplico per speed)

        float jump = Input.GetAxis("Jump"); //jump si trova in edit>project settings>input

        if (isOnGround){
			
            Vector3 jumpVector = new Vector3(0.0f, jump, 0.0f);
            rb.AddForce(jumpVector * jumpIntesity, ForceMode.Impulse); //ForceMode cambia il tipo di forza applicata

        }
    }

    //Quando il giocatore è a contatto col terreno, mettiamo la flag per indicarlo
    void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Ground")){
		   isOnGround = true;
		}
    }

    void OnCollisionExit(Collision other){
        if (other.gameObject.CompareTag("Ground")){
			isOnGround = false;
        }
    }
		
}

