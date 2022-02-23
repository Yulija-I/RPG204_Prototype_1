using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Shapes : MonoBehaviour
{
    public GameObject[] Shape;
    
    public int RandomNumber;  // random number
    public int ObjCount = 0;  // object count

    // Start is called before the first frame update
    void Start()
    {

        // object , time , reapeat 
        InvokeRepeating("RandomshapeGenerator", 1f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomshapeGenerator()
    {

        RandomNumber = Random.Range(0, 7);
        // while loop
        ObjCount = 0;
        while (ObjCount < 7)
        {
            Shape[ObjCount].SetActive(false); //  deactivate the object
            ObjCount += 1;

        }
        Shape[RandomNumber].SetActive(true);  // active the object 



    }
}
