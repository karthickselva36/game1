using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
Movement();
    }

    void Movement()
    {
     float x = Input.GetAxis("Horizontal");
     float z = Input.GetAxis("Vertical");
     float y = 0.1f;

     transform.Translate(x,y,z) ;  
    }
}
