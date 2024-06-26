using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour
{
    public Material[] Skyboxx;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
      //  RenderSettings.skybox = SkyBox1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void changeSkybox()
    {
        if (count < Skyboxx.Length /*&& istrue*/)
        {
            
            RenderSettings.skybox = Skyboxx[count];
            count++;
            Invoke("condition",0.01f);
        }
    }
    public void condition()
    {
        if (count == Skyboxx.Length)
        {
            count = 0;
        }
    }
}
