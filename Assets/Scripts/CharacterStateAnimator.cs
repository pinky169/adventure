using UnityEngine;
using System;
using System.Collections;

[System.Serializable]
public class CharacterStateAnimator
{
	private Animator anim;
	
	public void SetAnimator (Animator anim)
	{
		this.anim = anim;
	}
	
	[SerializeField]
	private CharacterState state;
	
	public enum CharacterState
	{
		Idle,
		Suffer,
		Dead,
		Moving,
		// TODO others
	}
	
	public CharacterState GetState ()
	{
		return state;
	}
	
	public void SetState (CharacterState state)
	{
		anim.SetBool (this.state.ToString (), false);
		this.state = state;
		anim.SetBool (this.state.ToString (), true);
	}
	
	public void SetState (string state)
	{
		CharacterState myState = (CharacterState) Enum.Parse (typeof (CharacterState), state, true);
		SetState (myState);
	}
}
