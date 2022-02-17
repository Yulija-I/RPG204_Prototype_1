using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape_Switch : MonoBehaviour
{
    public GameObject[] shapes;// different shapes
    
    // Start is called before the first frame update
    void Start()
    {

       
        
    }

    // Update is called once per frame
    void Update()
    {
        //or(int i = 0; i <=shapes.Length; i++)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // On space button press generate random shapes
            for (int i = 0; i <= shapes.Length; i++)
            {
                int RandomNumber = Random.Range(0, shapes.Length);
                Instantiate(shapes[RandomNumber],transform.position, Quaternion.identity);
                
            }
        }
        
       
        
        
       
        



    }
   
}
