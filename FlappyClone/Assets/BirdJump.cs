using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using = import (�ʿ��� ��� ������)

public class BirdJump : MonoBehaviour // ���(MonoBehaviour)
{
    Rigidbody2D rb; // �ڷ��� (�Ӽ����� ����ߴ� �� ->  Ŭ����)



    // Start is called before the first frame update
    void Start()
    {
        // �ڵ� ���� ��, ó�� �� ���� ����
        rb = GetComponent<Rigidbody2D>(); // ������Ʈ ������

    }

    // Update is called once per frame
    void Update()
    {
        // �� '������'���� ���� (60fps -> 1�ʿ� 60 ������)
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư ������ �� -> ����
        {
            rb.velocity = Vector2.up * 3;// (0,1) * 3 -> ���� 3��ŭ ������
        }

    }
}
