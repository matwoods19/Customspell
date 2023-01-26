using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cast"))
        {
            Debug.Log("start casting spell");
        }

        if (Input.GetAxis("Size") > 0)
        {
            Debug.Log("increasing size");

        }
        else if(Input.GetAxis("Size") < 0)
        {
            Debug.Log("decreasing size");
        }

        if(Input.GetAxis("Speed") > 0)
        {
            Debug.Log("increase speed");
        }
        else if(Input.GetAxis("Speed") < 0)
        {
            Debug.Log("decrease speed");
        }

        if(Input.GetAxis("Element") > 0)
        {
            Debug.Log("element");
        }
        else if(Input.GetAxis("Element") < 0)
        {
            Debug.Log("element");
        }
    }
}
