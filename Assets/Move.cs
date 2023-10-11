using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    private bool isStop = false;
    float speed = 5.0f;
    float targetX = -100.0f; // ���B���ׂ�X���W

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
            // �ڕW���W�ɓ��B�����瑬�x��0�ɐݒ�
            _rb.velocity = Vector3.zero;
            isStop = true; // ��~�t���O�𗧂Ă�
        }
    }
}
