using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene用

public class ClearDirector : MonoBehaviour
{
    void Update() {

        // 毎回更新


        // マウスボタンが押されたら
        if(Input.GetMouseButtonDown(0))
        {
            // GameSceneに移動
            SceneManager.LoadScene("GameScene");
        }
    }
}
