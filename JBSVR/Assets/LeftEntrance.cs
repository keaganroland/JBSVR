using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEntrance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            transform.position += new Vector3(-0.14f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.B))
        {
            transform.position -= new Vector3(-0.14f, 0f, 0f);
        }
    }
}
