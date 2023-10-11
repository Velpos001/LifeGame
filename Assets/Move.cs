using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    private bool isStop = false;
    float speed = 5.0f;
    float targetX = -100.0f; // 到達すべきX座標

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isStop)
        {
            _rb.velocity = -transform.right * speed;
        }

        if (transform.position.x <= targetX)
        {
            // 目標座標に到達したら速度を0に設定
            _rb.velocity = Vector3.zero;
            isStop = true; // 停止フラグを立てる
        }
    }
}
