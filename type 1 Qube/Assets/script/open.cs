using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour {

    public static bool fade;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator =GetComponent<Animator>();
        fade = false;
		
    }

    // Update is called once per frame
    void Update()
    {
		if (quiz1.clearflag)
		{
			this.animator.SetTrigger("open");


		}
		else if (quiz2.nextstage)
		{
			this.animator.SetTrigger("open");
		}

		
    }
}
