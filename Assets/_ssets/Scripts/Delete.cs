using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 슬라이드바에 맞춰서 입자크기 생성 양 조절?인듯

public class Delete : MonoBehaviour
{
    
    public Slider slider_;
    public GameObject[] particle;

    [SerializeField] private Toggle toggle1;
    [SerializeField] private Toggle toggle2;
    [SerializeField] private Toggle toggle3;
    [SerializeField] private Toggle toggle4;
    [SerializeField] private Toggle toggle5;
    [SerializeField] private Toggle toggle6;

    public void OnClickApply()
    {
        toggle1Count();
        toggle2Count();
        toggle3Count();
        toggle4Count();
        toggle5Count();
        toggle6Count();
    }


    void Start()
    {
        for (int i = 0; i < particle.Length; i++)
        {
            particle[i].SetActive(false);
        }
        toggle1.onValueChanged.AddListener(toggleChoice);
        toggle2.onValueChanged.AddListener(toggleChoice);
        toggle3.onValueChanged.AddListener(toggleChoice);
        toggle4.onValueChanged.AddListener(toggleChoice);
        toggle5.onValueChanged.AddListener(toggleChoice);
        toggle6.onValueChanged.AddListener(toggleChoice);

    }


    public void toggleChoice(bool arg0)
    {
        if (toggle1.isOn)
        {
            

        }
        else if (toggle2.isOn)
        {

        }
    }

    public void toggle1Count()
    {
        if (toggle1.isOn)
        {
            if (slider_.value < 1f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 10; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 2.5f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 5; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 7f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 3; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 11f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 2; i++)
                {
                    particle[i].SetActive(true);
                }
            }
        }
    }

    public void toggle2Count()
    {
        if (toggle2.isOn)
        {
            if (slider_.value < 1f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 3; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 2.5f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 2; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 11f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 1; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            
        }
    }

    public void toggle3Count()
    {
        if (toggle3.isOn)
        {
            
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 1; i++)
                {
                    particle[i].SetActive(true);
                }
           
            
        }
    }
    public void toggle4Count()
    {
        if (toggle4.isOn)
        {
            if (slider_.value < 1f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 16; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 2.5f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 12; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 7f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 11; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 11f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 10; i++)
                {
                    particle[i].SetActive(true);
                }
            }
        }
    }

    public void toggle5Count()
    {
        if (toggle5.isOn)
        {
            if (slider_.value < 1f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 31; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 2.5f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 28; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 7f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 23; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 11f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 17; i++)
                {
                    particle[i].SetActive(true);
                }
            }
        }
    }

    public void toggle6Count()
    {
        if (toggle6.isOn)
        {
            if (slider_.value < 1f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 49; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 2.5f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i <36; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 7f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 36; i++)
                {
                    particle[i].SetActive(true);
                }
            }
            else if (slider_.value < 11f)
            {
                for (int i = 0; i < particle.Length; i++)
                {
                    particle[i].SetActive(false);
                }
                for (int i = 0; i < 35; i++)
                {
                    particle[i].SetActive(true);
                }
            }
        }
    }


    private void Update()
    {
        
    }
    
}
