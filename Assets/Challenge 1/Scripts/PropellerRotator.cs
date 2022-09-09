using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotator : MonoBehaviour
{
    public GameObject propeller;
    private float angle = 180.0f;
    private int noOfTimes = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make propeller spin
        propeller.transform.Rotate(Vector3.back, angle * Time.deltaTime * noOfTimes);
    }
}
