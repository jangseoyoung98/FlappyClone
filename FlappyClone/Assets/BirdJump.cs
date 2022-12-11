using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using = import (필요한 모듈 가져옴)

public class BirdJump : MonoBehaviour // 상속(MonoBehaviour)
{
    Rigidbody2D rb; // 자료형 (속성으로 사용했던 거 ->  클래스)



    // Start is called before the first frame update
    void Start()
    {
        // 코드 실행 시, 처음 한 번만 실행
        rb = GetComponent<Rigidbody2D>(); // 컴포넌트 가져옴

    }

    // Update is called once per frame
    void Update()
    {
        // 매 '프레임'마다 실행 (60fps -> 1초에 60 프레임)
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 눌렀을 때 -> 점프
        {
            rb.velocity = Vector2.up * 3;// (0,1) * 3 -> 위로 3만큼 점프함
        }

    }
}
