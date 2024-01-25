using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class DisplayMultimeter : MonoBehaviour
{
    public GameObject Tumbler;

    public TextMeshProUGUI TextDisplay;

    public float R = 1000, P = 400;

    private void Start()
    {
        TextDisplay.text = "0";

    }
    void Update()
    {
        Vector3 rot = Tumbler.transform.eulerAngles;

        if (rot.z == 180) // off
        {
            TextDisplay.text = "0";
        }

        if (rot.z == 45 | rot.z == -135) // A
        {
            float A = (float)Math.Sqrt(P * R);
            TextDisplay.text = Math.Round(A, 2).ToString();
        }

        if (rot.z == 135) // Omega
        {
            TextDisplay.text = R.ToString();
        }

        if (rot.z == 225) // V
        {
            float V = (float)Math.Sqrt(P / R);
            TextDisplay.text = Math.Round(V, 2).ToString();
        }

        if (rot.z == 315) // V~
        {
            TextDisplay.text = "0.01";
        }

    }
}
