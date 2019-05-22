using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public float time_remaining = 120.0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.GetComponent<Text>().text = ((int)time_remaining).ToString();
        time_remaining -= Time.deltaTime;
    }

}
