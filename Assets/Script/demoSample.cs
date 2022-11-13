using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoSample : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    private int currentTarget;

    void Start()
    {
        currentTarget = 1;
        SetCamera(currentTarget);
    }
    public void SetCamera(int num)
    {
        switch (num)
        {
            case 1:
                camera1.SetActive(true);
                camera2.SetActive(false);
                camera3.SetActive(false);
                camera4.SetActive(false);
                break;
            case 2:
                camera1.SetActive(false);
                camera2.SetActive(true);
                camera3.SetActive(false);
                camera4.SetActive(false);
                break;
            case 3:
                camera1.SetActive(false);
                camera2.SetActive(false);
                camera3.SetActive(true);
                camera4.SetActive(false);
                break;
            case 4:
                camera1.SetActive(false);
                camera2.SetActive(false);
                camera3.SetActive(false);
                camera4.SetActive(true);
                break;
        }

    }
    public void SwitchCamera()
    {
        if (currentTarget < 4)
            currentTarget++;
        else
            currentTarget = 1;
        SetCamera(currentTarget);
    }

  
}
