using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[HelpURL("https://cosmosgames.me")]
[DisallowMultipleComponent]

public class WaterSurface : MonoBehaviour
{
    public Transform parentPlane;

    [Range(0, 1f)]
    public float waveLength = 0.02f;

    [Range(3, 10f)]
    public float groundWeavingRate = 3f;

    [Range(0, 1)]
    public float flowSpeed = 0.01f;


    public Color waterColor;
    public Color seaSurfaceFoam;
    public Color foamShade;



    void Start()
    {

        ColorUtility.TryParseHtmlString("#35A4FF", out seaSurfaceFoam);

        ColorUtility.TryParseHtmlString("#FFFFFF", out seaSurfaceFoam);

        ColorUtility.TryParseHtmlString("#2E8FDE", out foamShade);

        waveLength = 0.02f;
        groundWeavingRate = 3;
        flowSpeed = 0.01f;
    }

    void Update()
    {
        foreach (Transform child in parentPlane)
        {
            child.GetComponent<Renderer>().material.SetFloat("_Choppiness", waveLength);

            child.GetComponent<Renderer>().material.SetFloat("_Size", groundWeavingRate);

            child.GetComponent<Renderer>().material.SetFloat("_FlowSpeed", flowSpeed);

            child.GetComponent<Renderer>().material.SetColor("_WaterColor", waterColor);

            child.GetComponent<Renderer>().material.SetColor("_LightFoamColor", seaSurfaceFoam);

            child.GetComponent<Renderer>().material.SetColor("_DarkFoamColor", foamShade);
        }

    }



}
