using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizstart : MonoBehaviour
{

    public static bool moveflag;
    private Animator animator3;

    // Start is called before the first frame update
    void Start()
    {

        moveflag = false;
        animator3 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.A))
        {
            Quizstart();
        }

    }

    void Quizstart()
    {
        moveflag = true;
        this.animator3.SetTrigger("open");
    }

}
