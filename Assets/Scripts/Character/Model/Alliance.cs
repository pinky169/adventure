using UnityEngine;
using System.Collections;

[System.Serializable]
public class Alliance
{
	public enum Team
	{
		None,
		Red,
		Blue
	}
	
	[SerializeField]
	private Team team;
}
