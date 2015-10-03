using UnityEngine;
using System.Collections;

[System.Serializable]
public class Movement
{	
	public bool isMoving;
	public bool onGround;
	public float moveSpeed;
	public float jumpSpeed;
	public float checkRadius;
	public LayerMask mask;
	
	private Rigidbody rb;

	public void SetRigidbody (Rigidbody rb)
	{
		this.rb = rb;
	}

	// ASSERT: function called every Update()
	public void Move (Vector3 direction)
	{
		CheckGround ();
		isMoving = direction != Vector3.zero;
		
		if (isMoving)
		{
			rb.MovePosition (rb.position + direction * moveSpeed * Time.deltaTime);
			
			Quaternion targetRotation = Quaternion.LookRotation (direction);
			Quaternion newRotation = Quaternion.Slerp (rb.rotation, targetRotation, 20f * Time.deltaTime);
			rb.MoveRotation (newRotation);
		}
	}
	
	public void Jump ()
	{
		rb.AddForce (Vector3.up * jumpSpeed, ForceMode.Impulse);
	}
	
	private void CheckGround ()
	{
		onGround = Physics.CheckSphere(rb.position, checkRadius, mask);
	}
}