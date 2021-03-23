using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    [SerializeField] GameObject uiText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextShown());
    }

    IEnumerator TextShown()
    {
        yield return new WaitForSeconds(10);
        uiText.SetActive(false);
    }
}
