using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{
    public float zSpeed = 10f;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * zSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.X))
            transform.Translate(-Vector3.down * zSpeed * Time.deltaTime);
    }
}