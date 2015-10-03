using UnityEngine;
using System.Collections;

// Front class for all interactions in game
public class Character : MonoBehaviour 
{
	public string name;
	public Health health;
	public Alliance alliance;
	public Movement movement;
	public CharacterState state;
	
	void Start () 
	{
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

	// DO WE NEED THIS ?
	public void Suffer ()
	{
		// TODO
	}

	// Push button, lift chest etc..
	// Can be characte specific
	public void Activate ()
	{
		// TODO
	}
}