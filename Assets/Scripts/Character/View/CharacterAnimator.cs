using UnityEngine;
using System;
using System.Collections;

[System.Serializable]
public class CharacterAnimator
{
	private Animator anim;
	private CharacterState.State state;
	
	public void SetAnimator (Animator anim)
	{
		this.anim = anim;
	}
	
	public CharacterState.State GetState ()
	{
		return state;
	}
	
	public void SetState (CharacterState.State state)
	{
		if (this.state != state)
		{
			anim.SetBool (this.state.ToString (), false);
			this.state = state;
			anim.SetBool (this.state.ToString (), true);
		}
	}
	
	public void SetState (string state)
	{
		CharacterState.State myState = (CharacterState.State) Enum.Parse (typeof (CharacterState.State), state, true);
		SetState (myState);
	}

}
