using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	Character c;

	void Start () 
	{
		c = GetComponentInChildren<Character> ();
	}

	void Update () 
	{
		Vector3 direction = new Vector3 (Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		direction = Camera.main.transform.TransformDirection(direction);
		direction.y = 0;
		direction.Normalize ();
		c.Move (direction);
		
		
		if (Input.GetButtonDown("Jump"))
		{
			c.Jump();
		}
		
		// Process buttons
		// Process movement
	}
}
