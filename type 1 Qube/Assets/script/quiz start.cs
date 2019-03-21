using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizS: MonoBehaviour
{

    public static bool nextstage;
    public static bool moveflag;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        nextstage = false;
        moveflag = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            Quiz();
        }
    }

    void Quiz()
    {
        nextstage = true;
        moveflag = true;
        this.animator.SetTrigger("open");
    }
}