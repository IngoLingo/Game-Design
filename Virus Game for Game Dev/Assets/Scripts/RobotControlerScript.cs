using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControlerScript : MonoBehaviour
{
	[SerializeField]
	private Rigidbody playerBody;

	private Vector3 inputVector;

	public float playerSpeed;

	void Start () 
	{
		playerBody = GetComponent<Rigidbody>();
	}

    private void OnTriggerStay(Collider collideWith)
    {
        if (collideWith.gameObject.tag == "Player") 
        {
            inputVector = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, 0, Input.GetAxisRaw("Vertical") * playerSpeed);
            playerBody.velocity = inputVector;
        } 
        else
        {
            inputVector = new Vector3(0, 0, 0);
            playerBody.velocity = inputVector;
        }
    }
}