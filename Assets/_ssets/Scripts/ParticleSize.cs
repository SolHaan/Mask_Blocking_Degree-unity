using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 입자 크기 슬라이드바 숫자 적용 스크립트

public class ParticleSize : MonoBehaviour
{
    [SerializeField] private Text txt_size;
    [SerializeField] private Slider slider_size;

    private float currentSize;

    public void particleSlider()
    {
        currentSize = slider_size.value;
        txt_size.text = currentSize.ToString();
    }
    
    void Update()
    {
        particleSlider();
    }
}
