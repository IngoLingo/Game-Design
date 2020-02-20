using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour 
{

	[SerializeField]
	private Rigidbody playerBody;
	private Vector3 inputVector;
	public float playerSpeed;
	//public GameObject object1;
	//public GameObject object2;

	//Start
	void Start () 
	{
		playerBody = GetComponent<Rigidbody>();
	}

	//Update
	void Update () 
	{
		//inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, 0, Input.GetAxisRaw("Vertical") * playerSpeed);
		//playerBody.velocity = inputVector;
/*
        //Forward 
		if(Input.GetKey(KeyCode.W)) 
		{
			//if
				transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime); 
		}

		//Back 
        if(Input.GetKey(KeyCode.S)) 
		{
			//if
				transform.Translate(-Vector3.forward * playerSpeed * Time.deltaTime); 
		}

		//Left 
        if(Input.GetKey(KeyCode.A)) 
		{
			//if
				transform.Translate(-Vector3.right * playerSpeed * Time.deltaTime); 
		}

		//Right 
        if(Input.GetKey(KeyCode.D)) 
		{
			//if
				transform.Translate(Vector3.right * playerSpeed * Time.deltaTime); 
		}
*/
		/*Collider[] hits = Physics.OverlapSphere(transform.position, 10);
		foreach (Collider hit in hits)
		{
			if (hit.tag == "InfectableObjectCollision")
			{
				//Left 
				if(Input.GetKey(KeyCode.A)) 
				{
					if (hit.transform.position.x >= transform.position.x-0.1 && hit.transform.position.x <= transform.position.x-10
						&& hit.transform.position.z >= transform.position.z-10 && hit.transform.position.x <= transform.position.z+10)
					{
						transform.Translate(-Vector3.right * playerSpeed * Time.deltaTime);
						Debug.Log("HIT Left" + hit.transform.position.x + hit.transform.position.z);
					}
				}

				//Right 
				if(Input.GetKey(KeyCode.D)) 
				{
					if (hit.transform.position.x >= transform.position.x+0.1 && hit.transform.position.x <= transform.position.x+10
						&& hit.transform.position.z == transform.position.z)
					{
						transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
						Debug.Log("HIT Left" + hit.transform.position.x + hit.transform.position.z);
					}
				}
			}	
		}*/
	}
	
	
	//Collisions
	private void OnCollisionStay(Collision otherObject)
	{
   		if (otherObject.gameObject.tag == "WallCollision")
		{
			
   		}
		   
   		if (otherObject.gameObject.tag == "InfectableObjectCollision")
		{
			
   		}
 	}	

	//Triggers
	private void OnTriggerStay(Collider otherObject)
	{
   		if (otherObject.gameObject.tag == "WallCollision")
		{
			
   		}
		   
   		if (otherObject.gameObject.tag == "InfectableObjectCollision")
		{
			//inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, 0, Input.GetAxisRaw("Vertical") * playerSpeed);
			//playerBody.velocity = inputVector;
   		}
 	}
}