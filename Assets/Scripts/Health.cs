using UnityEngine;
using System.Collections;

[System.Serializable]
public class Health
{
	[SerializeField]
	private int current = 100;
	public int Current
	{
		get {return current;}
		set
		{
			current = Mathf.Min (value, max);
		}
	}
	
	[SerializeField]
	private int max = 100;
	public int Max
	{
		get {return max;}
		set 
		{
			max = value;
			Current = Mathf.Min (max, current);
		}
	}
}