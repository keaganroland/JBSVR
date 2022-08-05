using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Ele_Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            transform.position += new Vector3(+0.04f, 0f, -0.06f);
        }

        if (Input.GetKey(KeyCode.C))
        {
            transform.position -= new Vector3(+0.04f, 0f, -0.06f);
        }
    }
}
