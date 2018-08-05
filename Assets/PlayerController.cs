using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 780.0f;
    float walkForce = 20.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

    void Start() {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        // ジャンプする
        if(Input.GetMouseButtonDown(0)&&rigid2D.velocity.y == 0)
        {
            
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // 左右移動
        int key = 0;
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < this.threshold) key = -1;

//        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
//        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // プレイヤの速度
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        // スピード制限
        if( speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        // 動く方向に応じて反転
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // 画面外に出た場合は最初から
        if (transform.position.y < -10) {
            SceneManager.LoadScene("GameScene");
        }
        // プレイヤーの速度に応じてアニメーション速度を変える
        animator.speed = speedx / 2.0f;
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("ゴール");
        SceneManager.LoadScene("ClearScene");
    }
}
