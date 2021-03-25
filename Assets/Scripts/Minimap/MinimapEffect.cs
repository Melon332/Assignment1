using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class MinimapEffect : MonoBehaviour
{
    public Shader effectShader;
    private void OnEnable()
    {
        if(effectShader != null)
        {
            GetComponent<Camera>().SetReplacementShader(effectShader, "");
            Debug.Log("found camera" + GetComponent<Camera>());
        }
    }
    private void OnDisable()
    {
        GetComponent<Camera>().ResetReplacementShader();
    }
}
