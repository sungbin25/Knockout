using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public GameObject settingsPanel; // 설정 창을 나타내는 패널
    public Slider volumeSlider; // 볼륨 조절 슬라이더

    void Start()
    {
        // 기존 저장된 볼륨값을 불러와 슬라이더와 오디오에 적용
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1.0f);
        volumeSlider.value = savedVolume;
        AudioListener.volume = savedVolume;

        // 슬라이더 이벤트에 볼륨 변경 메서드 연결
        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeChange(); });
    }

    // 설정 버튼을 눌렀을 때 설정 창을 보여줌
    public void OnSettingsButtonClicked()
    {
        settingsPanel.SetActive(true);
    }

    // X 버튼을 눌렀을 때 설정 창을 닫음
    public void OnCloseButtonClicked()
    {
        settingsPanel.SetActive(false);
    }

    // 볼륨 슬라이더 값이 변경되었을 때 호출
    public void OnVolumeChange()
    {
        AudioListener.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
}