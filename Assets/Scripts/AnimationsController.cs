using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsController : MonoBehaviour 
{
	public string triggerToSet;

	private Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator> ();
	}

	public void SetTrigger()
	{
		anim.SetTrigger (triggerToSet);
	}
}
