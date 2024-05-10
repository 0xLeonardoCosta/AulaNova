using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    //[SerializeField] float _valor;

    Slider _slider;

    [SerializeField] float timerTotal, oldTimer, _speed; 
    [SerializeField] bool isRunning;

    void Start()
    {
        _slider = GetComponent<Slider>();

        oldTimer = timerTotal;

        _slider.maxValue = timerTotal;
        //_slider.value = 5;
    }

    
    void Update()
    {
        _slider.value = timerTotal;

        if (isRunning)
        {
            timerTotal -= Time.deltaTime * _speed;
            _slider.value = timerTotal;

            if (timerTotal < 0)
            {
                isRunning = false;
            }
        }
        if (!isRunning)
        {
            timerTotal += Time.deltaTime * _speed;
            _slider.value = timerTotal;

            if (timerTotal > 10)
            {
                isRunning = true;
            }
        }
        
        
        
        //_slider.value = _valor;
    }
}