using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooter : MonoBehaviour
{

    public GameObject bullet_prefab;
    public GameObject bullet_position;
    public float time_between_shoots = 1.0f;
    private float shoot_timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot_timer += Time.deltaTime;
        if(shoot_timer > time_between_shoots)
        {
            GameObject new_bullet = Instantiate(bullet_prefab);
            new_bullet.transform.position = gameObject.transform.position;
            new_bullet.transform.rotation = gameObject.transform.rotation;
            new_bullet.SetActive(true);
            shoot_timer = 0.0f;
        }
    }
}
