using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        //위
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }
        //아래
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }
        //왼쪽
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
        }
        //오른쪽
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
        }
    }
}
