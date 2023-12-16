using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    private bool isStop = false;
    float _speed = 5.0f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isStop)
        {
            //前に移動
            _rb.velocity = transform.forward * _speed;

            // Horizontal軸の入力を取得
            float horizontalInput = Input.GetAxis("Horizontal");

            // 移動ベクトルを作成
            Vector3 movement = new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime;

            // キャラクターを移動させる
            transform.Translate(movement);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("red"))
        {
            // 目標座標に到達したら速度を0に設定
            _rb.velocity = Vector3.zero;
            Debug.Log("stop");
            isStop = true; // 停止フラグを立てる
        }
    }
}
