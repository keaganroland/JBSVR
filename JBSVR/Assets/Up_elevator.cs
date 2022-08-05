using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Up_elevator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.U))
        {
            transform.position += new Vector3(0, 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(0, 0.01f, 0);
        }

        //if (Input.GetKey(KeyCode.D))
        //{
        //    tramsform.position += new Vector3(0, -1, 0);
        //}
    }
}
