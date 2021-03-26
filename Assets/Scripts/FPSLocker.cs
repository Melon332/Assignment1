using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSLocker : MonoBehaviour
{
    [SerializeField] Text fpsText;

    int avgFrameRate;

    public int targetFrameRate = 144;

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
    }
    public void Update()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        fpsText.text = avgFrameRate.ToString() + " FPS";
    }
}
