using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz1 : MonoBehaviour
{

	public static bool clearflag;
	public static bool fade;
	private Animator animator;
	[SerializeField] private string anserword;
	// Use this for initialization
	void Start()
	{
		fade = false;
		clearflag = false;
		animator = GetComponent<Animator>();
		
	}

	// Update is called once per frame
	void Update()
	{
		if (buttonclick.anwer == anserword)
		{
			Quiz1();
		}
	
	}


	void Quiz1()
	{
		clearflag= true;
		buttonclick.anwer = null;
		this.animator.SetTrigger("open");
		fade = true;
	}
	
}
