using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed; // 기둥의 이동 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x, y, z 세 개이므로 3로 해야 함
        // transform.position += Vector3.left; (-1, 0, 0) -> 매 프레임마다 왼쪽으로 한 칸씩 변경됨
        // 근데 위에는 문제가 있을 수 있다. FPS가 다른 컴퓨터 환경에 대해 해결 방안 -> Time.deltaTime 사용 (한 프레임에 걸리는 시간) -> 델타 타임을 곱하면 모두 이동거리가 동일해짐
        transform.position += Vector3.left * Time.deltaTime * speed;


        // 트랜스폼은 기본적으로 가지고 있음
        Debug.Log(transform.position);
        
    }
}
