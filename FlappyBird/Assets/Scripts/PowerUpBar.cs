using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpBar : MonoBehaviour
{
    public Slider slider;
    public float FillSpeed = 0.5f;
    public float targetProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    
    void Start ()
    {
        IncrementProgress(1f);
    }

    void Update ()
    {
        if(slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }else{
            StartCoroutine(DecrementProgress());
        }
    }

    IEnumerator DecrementProgress()
    {
        yield return new WaitForSeconds(3f);
        slider.value = 0;
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
