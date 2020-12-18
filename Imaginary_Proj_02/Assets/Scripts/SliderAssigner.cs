using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderAssigner : MonoBehaviour
{
    public Slider musicVolume;


    private void Awake()
    {
        musicVolume = GetComponent<Slider>();
        musicVolume.value = AudioManager.Instance.BackgroundMusicVolume;
        musicVolume.onValueChanged.AddListener(OnValueChange);


    }

    public void OnValueChange(float value)
    {
        AudioManager.Instance.SetLevel(value);
    }
}
