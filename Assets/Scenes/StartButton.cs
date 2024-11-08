using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위해 추가

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 버튼 클릭 시 호출될 메서드
    public void OnStartButtonClicked()
    {
        // "GameScene"은 실제 게임 씬의 이름으로 변경해야 합니다.
        SceneManager.LoadScene("GameScene");
    }
}