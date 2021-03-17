using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] InputManager inputManager;

    [SerializeField] Transform player;

    float rotationOnX;
    // Start is called before the first frame update
    void Start()
    {
        inputManager.mouseMovement += InputManager_mouseMovement;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void InputManager_mouseMovement(object sender, (float, float) e)
    {
        if (e.Item2 > 0 || e.Item2 < 0)
        {
            rotationOnX -= e.Item2;
            rotationOnX = Mathf.Clamp(rotationOnX, -90f, 90);
            transform.localEulerAngles = new Vector3(rotationOnX, 0f, 0f);
        }
        if (e.Item1 > 0 || e.Item1 < 0)
        {
            player.Rotate(Vector3.up, e.Item1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
