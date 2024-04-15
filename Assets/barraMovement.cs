using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class barraMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(0, moveAmount, 0);
    }

       
    
}
