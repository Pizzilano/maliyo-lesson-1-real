using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(50,0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // LateUpdate is called just after Update does its job
    void LateUpdate()
    {
        //make camera follow the GameObject (plane)
        transform.position = plane.transform.position + offset;
    }
}
