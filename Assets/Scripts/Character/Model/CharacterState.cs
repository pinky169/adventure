using UnityEngine;
using System;
using System.Collections;

[System.Serializable]
public class CharacterState
{
	public State state;
	public enum State
	{
		Idle,
		Suffer,
		Dead,
		Moving,
		// TODO others
	}
}
