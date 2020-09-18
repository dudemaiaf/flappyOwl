using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    GameObject a;
    public PowerUpBar power;
    void Start()
    {
        a = GameObject.Find("PowerUp");

        power = a.GetComponent<PowerUpBar>();
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(power.slider.value >= 1)
        {
            Score.score++;
            Score.score++;
        }else{
            Score.score++;
        }
    }
}
