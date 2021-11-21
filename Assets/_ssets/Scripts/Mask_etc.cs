using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//마스크 종류에 이름 표기 스크립트

public class Mask_etc : MonoBehaviour
{
    public GameObject[] mask;
    public Toggle[] alltoggle;

    public static Toggle firstTickedToggle;
    [SerializeField] private Toggle toggle1;
    [SerializeField] private Toggle toggle2;
    [SerializeField] private Toggle toggle3;
    [SerializeField] private Toggle toggle4;
    [SerializeField] private Toggle toggle5;
    [SerializeField] private Toggle toggle6;

    public Text Toggle_text;

    public void toggleChoice(bool arg0)
    {
        if (toggle1.isOn)
        {
            Toggle_text.text = "KF80";
            mask[0].SetActive(true);
            mask[1].SetActive(false);
            mask[2].SetActive(false);
            mask[3].SetActive(false);
            mask[4].SetActive(false);
            mask[5].SetActive(false);
        }
        else if (toggle2.isOn)
        {
            Toggle_text.text = "KF94";
            mask[0].SetActive(false);
            mask[1].SetActive(true);
            mask[2].SetActive(false);
            mask[3].SetActive(false);
            mask[4].SetActive(false);
            mask[5].SetActive(false);

        }
        else if (toggle3.isOn)
        {
            Toggle_text.text = "KF99";
            mask[0].SetActive(false);
            mask[1].SetActive(false);
            mask[2].SetActive(true);
            mask[3].SetActive(false);
            mask[4].SetActive(false);
            mask[5].SetActive(false);

        }
        else if (toggle4.isOn)
        {
            Toggle_text.text = "덴탈마스크";
            mask[0].SetActive(false);
            mask[1].SetActive(false);
            mask[2].SetActive(false);
            mask[3].SetActive(true);
            mask[4].SetActive(false);
            mask[5].SetActive(false);

        }
        else if (toggle5.isOn)
        {
            Toggle_text.text = "천마스크";
            mask[0].SetActive(false);
            mask[1].SetActive(false);
            mask[2].SetActive(false);
            mask[3].SetActive(false);
            mask[4].SetActive(true);
            mask[5].SetActive(false);

        }
        
        else if (toggle6.isOn)
        {
            Toggle_text.text = "손수건";
            mask[0].SetActive(false);
            mask[1].SetActive(false);
            mask[2].SetActive(false);
            mask[3].SetActive(false);
            mask[4].SetActive(false);
            mask[5].SetActive(true);
        }
        
    }


    void Start()
    {
        for (int i = 0; i < mask.Length; i++)
        {
            mask[i].SetActive(false);
        }
        toggle1.onValueChanged.AddListener(toggleChoice);
        toggle2.onValueChanged.AddListener(toggleChoice);
        toggle3.onValueChanged.AddListener(toggleChoice);
        toggle4.onValueChanged.AddListener(toggleChoice);
        toggle5.onValueChanged.AddListener(toggleChoice);
        toggle6.onValueChanged.AddListener(toggleChoice);
    }

}
