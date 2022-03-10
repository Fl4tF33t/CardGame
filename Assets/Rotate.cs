using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime);
    }
   
    
}
