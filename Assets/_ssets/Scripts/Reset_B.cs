using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_B : MonoBehaviour
{
 public void ReStart()
    { 
        // 현재 씬 초기화
        SceneManager.LoadScene("Mask6");
    }
}