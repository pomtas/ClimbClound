using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // playerのGameObject
    GameObject player;

    void Start() {
        // GameObjectから"cat"の名前のオブジェクトを探す
        player = GameObject.Find("cat");   
    }

    void Update() {
        // プレイヤーのポジションを取得
        Vector3 playerPos = this.player.transform.position;

        // 本オブジェクトカメラのY座標をプレイヤーの座標に合わせる
        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
    }
}
