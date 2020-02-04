using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour 
{

	[SerializeField]
	private Rigidbody playerBody;
	private Vector3 inputVector;
	public float playerSpeed;

	//Start
	void Start () 
	{
		playerBody = GetComponent<Rigidbody>();
	}

	//Update
	void Update () 
	{
			inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, 0, Input.GetAxisRaw("Vertical") * playerSpeed);
			playerBody.velocity = inputVector;
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