using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizstart : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private GameObject select;
    public static bool moveflag;
    private Animator animator3, closeanimator;


    // Start is called before the first frame update
    void Start()
    {

        moveflag = false;
        animator3 = GetComponent<Animator>();
        closeanimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Quizstart();

        }


    }

    void Quizstart()
    {
        select = null;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << 10))
        {
            select = hit.collider.gameObject;
            switch (select.name)
            {
                case "openbutton":
                    moveflag = true;
                    this.animator3.SetTrigger("open");
                    this.closeanimator.SetTrigger("close");
                    break;
            }


        }
    }


}
