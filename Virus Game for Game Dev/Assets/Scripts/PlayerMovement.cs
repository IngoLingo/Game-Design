using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private Rigidbody playerBody;

	private Vector3 inputVector;

	public float playerSpeed;

	void Start () 
	{
		playerBody = GetComponent<Rigidbody>();
	}
	

	void Update () 
	{
		inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, 0, Input.GetAxisRaw("Vertical") * playerSpeed);
		playerBody.velocity = inputVector;
	}
}