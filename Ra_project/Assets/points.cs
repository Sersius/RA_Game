using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{

    public int points_a = 0;
    public int points_b = 0;
    public GameObject win_red;
    public GameObject win_blue;
    public GameObject draw;
    public GameObject timer;
    public GameObject replay_but;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.GetComponent<Timer>().time_remaining <= 0)
        {
            if(points_a > points_b)
            {
                win_red.SetActive(true);
            }

            else if (points_a < points_b)
            {
                win_blue.SetActive(true);
            }

            else if (points_a == points_b) {
                draw.SetActive(true);
            }

            replay_but.SetActive(true);

            Time.timeScale = 0.0f;
        }
    }
}
