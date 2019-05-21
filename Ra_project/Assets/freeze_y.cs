using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze_y : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Initial_rot;

    void Start()
    {
        Initial_rot = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(gameObject.transform.position.x, Initial_rot.position.y, gameObject.transform.position.z, Space.World);
    }
}
