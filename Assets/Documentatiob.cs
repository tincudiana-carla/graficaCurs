using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Documentatiob : MonoBehaviour
{
    public GameObject textCanvas;

    void Start()
    {
        textCanvas.SetActive(false);
    }

    public void OnButtonClick()
    {
        textCanvas.SetActive(!textCanvas.activeSelf);
    }
}
