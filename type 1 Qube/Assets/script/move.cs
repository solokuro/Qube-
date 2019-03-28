using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (quizstart.moveflag) Invoke("Move", 3f);
        if (quiz2.moveflag2) Invoke("Move2", 3f);
        if (Input.GetKey(KeyCode.Space)) stageback();


    }
    void Move()
    {
        Transform mytransform = this.transform;

        Vector3 worldpos = mytransform.position;
        worldpos.x = 0.0f;
        worldpos.y = 1.5f;
        worldpos.z = 4.5f;
        mytransform.position = worldpos;
    }
    void Move2()
    {
        Transform mytransform = this.transform;

        Vector3 worldpos = mytransform.position;
        worldpos.x = 0.0f;
        worldpos.y = 1.5f;
        worldpos.z = 13.0f;
        mytransform.position = worldpos;
    }
    void stageback()
    {
        Transform mytransform = this.transform;

        Vector3 worldpos = mytransform.position;
        worldpos.x = 0.0f;
        worldpos.y = 1.5f;
        worldpos.z = 13.0f;
        mytransform.position = worldpos;
    }
  


}
