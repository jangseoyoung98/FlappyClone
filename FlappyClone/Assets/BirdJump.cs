using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using = import (필요한 모듈 가져옴)

public class BirdJump : MonoBehaviour // 상속(MonoBehaviour)
{
    // Start is called before the first frame update
    void Start()
    {
        // 코드 실행 시, 처음 한 번만 실행
        Debug.Log("Start입니다~!"); // print
    }

    // Update is called once per frame
    void Update()
    {
        // 매 '프레임'마다 실행 (60fps -> 1초에 60 프레임)
        Debug.Log("Update입니다~!"); // print

    }
}
