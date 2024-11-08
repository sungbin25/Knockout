using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public GameObject settingsPanel; // ���� â�� ��Ÿ���� �г�
    public Slider volumeSlider; // ���� ���� �����̴�

    void Start()
    {
        // ���� ����� �������� �ҷ��� �����̴��� ������� ����
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1.0f);
        volumeSlider.value = savedVolume;
        AudioListener.volume = savedVolume;

        // �����̴� �̺�Ʈ�� ���� ���� �޼��� ����
        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeChange(); });
    }

    // ���� ��ư�� ������ �� ���� â�� ������
    public void OnSettingsButtonClicked()
    {
        settingsPanel.SetActive(true);
    }

    // X ��ư�� ������ �� ���� â�� ����
    public void OnCloseButtonClicked()
    {
        settingsPanel.SetActive(false);
    }

    // ���� �����̴� ���� ����Ǿ��� �� ȣ��
    public void OnVolumeChange()
    {
        AudioListener.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
}