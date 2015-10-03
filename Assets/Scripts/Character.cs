using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
	public Health health;
	public Alliance alliance;
	public Movement movement;
	public CharacterStateAnimator state;
	
	void Start () 
	{
		state.SetAnimator (GetComponent<Animator> ());
		movement.SetRigidbody (GetComponent<Rigidbody> ());
	}

	// ASSERT: function called every Update()
	public void Move (Vector3 direction)
	{
		movement.Move (direction);
	}
	
	public void Jump ()
	{
		if (movement.onGround)
			movement.Jump ();
	}
	
	public void Attack ()
	{
		// TODO
	}
	
	public void Suffer ()
	{
		// TODO
	}
}