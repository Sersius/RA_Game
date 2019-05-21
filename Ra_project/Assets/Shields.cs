using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{

    public float rotation_vel = 1.0f;
    public GameObject ship;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(ship.transform.position, Vector3.up, rotation_vel * Time.deltaTime);
    }
}
