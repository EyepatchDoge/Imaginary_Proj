using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    [Header("General")]
    public Camera uiCamera;
    public GameObject backgroundPanel;
    public GameObject circleMenuElementPrefab;
    public bool useGradient;

    [Header("Buttons")]
    public Color normaButton;
}
