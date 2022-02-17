using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Shapes : MonoBehaviour
{
    public GameObject[] Shape;
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
        // generate the random shapes on the panel
        int RandomNum = Random.Range(0, Shape.Length);
        Instantiate(Shape[RandomNum], transform.position, Quaternion.identity);
        
       


    }
}
