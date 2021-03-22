using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class MinimapEffect : MonoBehaviour
{
    private void Start()
    {
        Camera.main.SetReplacementShader(Shader.Find("MinimapShader"), "RenderType");
    }
    private void OnEnable()
    {
        Camera.main.SetReplacementShader(Shader.Find("MinimapShader"), "RenderType");
    }
}



