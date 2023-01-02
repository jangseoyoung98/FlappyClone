// #2. 22/12/31_일단 Text UI 안 뜨는 거 Anchors 건드려서 해결은 함
// ★ 이전이랑 비교하면서, 뭐가 달라진 건지 확인하기!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI 다루기 위해 using을 추가한다.

public class Score2 : MonoBehaviour
{
    public static int score = 0;   // 초기 점수는 0으로 시작한다.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Text>().text = score.ToString(); // 점수를 누적해 Text UI로 보여준다.

    }
}
