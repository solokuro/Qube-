using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz2 : MonoBehaviour
{

    private Ray ray;
    private RaycastHit hit;
    private GameObject select;
    public static bool moveflag2;
    private Animator animator2,closeanimator;

    // Start is called before the first frame update
    void Start()
    {

        moveflag2 = false;
        animator2 = GetComponent<Animator>();
        closeanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Quiz2();
        }
    }

    void Quiz2()
    {
        select = null;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << 11))
        {
            select = hit.collider.gameObject;
            switch (select.name)
            {
              case "openbutton2":
              moveflag2 = true;
              this.animator2.SetTrigger("open");
              this.closeanimator.SetTrigger("close");
              break;
            }

            
        
        }


    } 


}


