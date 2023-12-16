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
            //�O�Ɉړ�
            _rb.velocity = transform.forward * _speed;

            // Horizontal���̓��͂��擾
            float horizontalInput = Input.GetAxis("Horizontal");

            // �ړ��x�N�g�����쐬
            Vector3 movement = new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime;

            // �L�����N�^�[���ړ�������
            transform.Translate(movement);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("red"))
        {
            // �ڕW���W�ɓ��B�����瑬�x��0�ɐݒ�
            _rb.velocity = Vector3.zero;
            Debug.Log("stop");
            isStop = true; // ��~�t���O�𗧂Ă�
        }
    }
}
