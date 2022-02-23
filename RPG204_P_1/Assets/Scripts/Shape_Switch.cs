using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape_Switch : MonoBehaviour
{
    public GameObject[] shapes;   // Different shapes
    public int RandomNumber;  // random number
    public int ObjCount = 0;  // object count


    // Start is called before the first frame update
    void Start()
    {

       
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomNumber = Random.Range(0, 7);
            // while loop
            ObjCount = 0;
            while(ObjCount < 7)
            {
                shapes[ObjCount].SetActive(false); //  deactivate the object
                ObjCount += 1;

            }
            shapes[RandomNumber].SetActive(true);  // active the object 

        }


        ////or(int i = 0; i <=shapes.Length; i++)
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    // On space button press generate random shapes
        //    for (int i = 0; i <= shapes.Length; i++)
        //    {
        //        int RandomNumber = Random.Range(0, shapes.Length);
        //        Instantiate(shapes[RandomNumber],transform.position, Quaternion.identity);
                
        //    }
        //}
        
       
        
        
       
        



    }
   
}
