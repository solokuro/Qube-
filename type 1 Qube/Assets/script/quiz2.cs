using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz2 : MonoBehaviour
{

	public static bool nextstage;
	public static bool moveflag2;
	private Animator animator2;
	
    // Start is called before the first frame update
    void Start()
    {
		nextstage = false;
		moveflag2 = false;
		animator2 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
		{
			Quiz2();
		}
    }

	void Quiz2()
	{
		nextstage = true;
		moveflag2 = true;
		this.animator2.SetTrigger("open");
	}
}
