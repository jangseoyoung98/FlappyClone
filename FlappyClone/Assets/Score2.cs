// #1. 22/12/31_Score ���� �����ϰ� 2�� �ٽ� ������
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI �ٷ�� ���� using�� �߰��Ѵ�.

public class Score2 : MonoBehaviour
{
    public static int score = 0;   // �ʱ� ������ 0���� �����Ѵ�.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Text>().text = score.ToString(); // ������ ������ Text UI�� �����ش�.

    }
}
