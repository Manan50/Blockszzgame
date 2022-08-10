using System.Reflection.Emit;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowSliderValue : MonoBehaviour
{
    public AudioMixer musicMixer;
    public Slider musicSlider;
    void Awake()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        musicMixer.SetFloat("MusicVolume", musicSlider.value);
    }

    public void UpdateLabel(float value)
    {
        TextMeshProUGUI lbl = GetComponent<TextMeshProUGUI>();
        if (lbl != null)
            lbl.text = Mathf.RoundToInt(value + 64f * 1.25f) + "%";
        musicMixer.SetFloat("MusicVolume", value);
        PlayerPrefs.SetFloat("MusicVolume", value);


    }
}
