using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour 
{

	public float playerSpeed;

	void Start () 
	{
		//playerBody = GetComponent<Rigidbody>();
	}
	

	void Update () 
	{
        //Forward
		if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        
		//Back
        if(Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * playerSpeed * Time.deltaTime);
		
		//Left
        if(Input.GetKey(KeyCode.A))
            transform.Translate(-Vector3.right * playerSpeed * Time.deltaTime);
        
		//Right
        if(Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
		
		//inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, 0, Input.GetAxisRaw("Vertical") * playerSpeed);
		//playerBody.velocity = inputVector;
	}
}