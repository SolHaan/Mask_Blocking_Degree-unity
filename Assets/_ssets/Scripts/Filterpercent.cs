using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filterpercent : MonoBehaviour
{




    public static Toggle firstTickedToggle;
    [SerializeField] private Toggle toggle1;
    [SerializeField] private Toggle toggle2;
    [SerializeField] private Toggle toggle3;
    [SerializeField] private Toggle toggle4;
    [SerializeField] private Toggle toggle5;
    [SerializeField] private Toggle toggle6;

    [SerializeField] private Text trans_rate;
    [SerializeField] private Text filterSize;
    [SerializeField] private Slider slider_size;

    private float currentSize;
    private float plusSize;
    private float rate;


    public void toggleChoice(bool arg0)
    {
    }

        public void togglepercent()
    {
        currentSize = slider_size.value;

        if (toggle1.isOn)
        {
            if (currentSize < 1.1f)
            {
                currentSize += 80;
                filterSize.text = currentSize.ToString();
                rate = 100f - currentSize;
                trans_rate.text = rate.ToString();
            }
            else
            {
                plusSize = currentSize * 1.5f + 80;
                filterSize.text = plusSize.ToString();
                rate = 100f - plusSize;
                trans_rate.text = rate.ToString();
            }
            


        }
        else if (toggle2.isOn)
        {
            if(currentSize<1.1f)
            {
                currentSize += 94;
                filterSize.text = currentSize.ToString();
                rate = 100f - currentSize;
                trans_rate.text = rate.ToString();
            }
            else if(currentSize>1.0f&&currentSize<2.6)
            {
                plusSize = currentSize * 1.6f + 94;
                filterSize.text = plusSize.ToString();
                rate = 100f - plusSize;
                trans_rate.text = rate.ToString();
            }
            else
            {
                currentSize = 99;
                filterSize.text = currentSize.ToString();
                rate = 100f - currentSize;
                trans_rate.text = rate.ToString();
            }

        }
        else if (toggle3.isOn)
        {
            currentSize = 99;
            filterSize.text = currentSize.ToString();
            rate = 100f - currentSize;
            trans_rate.text = rate.ToString();

        }
        else if (toggle4.isOn)
        {
            if (currentSize < 1.1f)
            {
                currentSize += 67;
                filterSize.text = currentSize.ToString();
                rate = 100f - currentSize;
                trans_rate.text = rate.ToString();
            }
            else 
            {
                plusSize = currentSize * 1.3f + 67;
                filterSize.text = plusSize.ToString();
                rate = 100f - plusSize;
                trans_rate.text = rate.ToString();
            }
            
            

        }
        else if (toggle5.isOn)
        {
            if (currentSize < 1.1f)
            {
                currentSize += 38;
                filterSize.text = currentSize.ToString();
                rate = 100f - currentSize;
                trans_rate.text = rate.ToString();
            }
            else
            {
                plusSize = currentSize * 2.7f + 38;
                filterSize.text = plusSize.ToString();
                rate = 100f - plusSize;
                trans_rate.text = rate.ToString();
            }
        }

        else if (toggle6.isOn)
        {
            if (currentSize < 1.1f)
            {
                currentSize += 2;
                filterSize.text = currentSize.ToString();
                rate = 100f - currentSize;
                trans_rate.text = rate.ToString();
            }
            else
            {
                plusSize = currentSize * 2.8f + 2;
                filterSize.text = plusSize.ToString();
                rate = 100f - plusSize;
                trans_rate.text = rate.ToString();
            }

        }

    }


    void Start()
    {
        
        toggle1.onValueChanged.AddListener(toggleChoice);
        toggle2.onValueChanged.AddListener(toggleChoice);
        toggle3.onValueChanged.AddListener(toggleChoice);
        toggle4.onValueChanged.AddListener(toggleChoice);
        toggle5.onValueChanged.AddListener(toggleChoice);
        toggle6.onValueChanged.AddListener(toggleChoice);
    }

    private void Update()
    {
        togglepercent();
    }

}
