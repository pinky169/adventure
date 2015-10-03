using UnityEngine;
using System.Collections;

public class CharacterDisplay : MonoBehaviour 
{
	private Character character;
	
	//public FlaskDisplay currentHealth;
	
	void Start ()
	{
		character = GetComponent<Character> ();
	}
	
	public void UpdateDisplays ()
	{
		//currentHealth.Value = character.health.Current * 100 / character.health.Max;
	}
}
