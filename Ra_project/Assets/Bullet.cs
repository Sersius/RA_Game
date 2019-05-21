using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public float bullet_speed = 10.0f;
    public GameObject bullet_dir;
    public GameObject canvas;
    private Vector3 direction;
    public float bullet_lifetime = 2.5f;
    private float bullet_time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        direction = bullet_dir.transform.position - gameObject.transform.position;
        direction.Normalize();

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(direction * bullet_speed * Time.deltaTime, Space.World);
        bullet_time += Time.deltaTime;
        if (bullet_time > bullet_lifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 10)
        {
            canvas.transform.GetComponent<points>().points_b += 1;
            canvas.transform.GetChild(0).GetComponent<Text>().text = canvas.transform.GetComponent<points>().points_b.ToString();
        }

        else if (other.gameObject.layer == 11)
        {
            canvas.transform.GetComponent<points>().points_a += 1;
            canvas.transform.GetChild(1).GetComponent<Text>().text = canvas.transform.GetComponent<points>().points_a.ToString();
        }

        else if (other.gameObject.layer == 9)
        {
            direction = -direction;
        }
    }
}
