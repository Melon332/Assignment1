using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class MinimapEffect : MonoBehaviour
{
    [SerializeField] Camera minimapCamera;
    [SerializeField] Shader minimapShader;
    private void Start()
    {
        minimapCamera.SetReplacementShader(minimapShader, "Transparent");
    }

}



