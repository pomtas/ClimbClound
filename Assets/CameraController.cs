using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // playerのGameObject
    GameObject player;

    void Start() {
        // 最初だけ更新

        // GameObjectから"cat"の名前のオブジェクトを探す
        player = GameObject.Find("cat");   
    }

    void Update() {
        // 毎回更新

        // プレイヤーのポジションを取得
        Vector3 playerPos = this.player.transform.position;

        // 本オブジェクトカメラのY座標をプレイヤーの座標に合わせる
        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
    }
}
