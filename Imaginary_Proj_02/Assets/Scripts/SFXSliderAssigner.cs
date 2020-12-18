using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXSliderAssigner : MonoBehaviour
{
    public Slider sfxVolume;

    // Start is called before the first frame update
    void Awake()
    {
        sfxVolume = GetComponent<Slider>();
        sfxVolume.value = AudioManager.Instance.SFXMusicVolume;
        sfxVolume.onValueChanged.AddListener(OnValueSFXChange);
    }

    public void OnValueSFXChange(float value)
    {
        AudioManager.Instance.SetSFXLevel(value);
    }
}
