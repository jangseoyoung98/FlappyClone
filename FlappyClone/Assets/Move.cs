using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// prefab ������Ʈ �ݺ� -> Assests ���� �ȿ� ���� ������ �ڵ����� prefab�� �Ǵ� ��

public class Move : MonoBehaviour
{
    public float speed; // ����� �̵� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x, y, z �� ���̹Ƿ� 3�� �ؾ� ��
        // transform.position += Vector3.left; (-1, 0, 0) -> �� �����Ӹ��� �������� �� ĭ�� �����
        // �ٵ� ������ ������ ���� �� �ִ�. FPS�� �ٸ� ��ǻ�� ȯ�濡 ���� �ذ� ��� -> Time.deltaTime ��� (�� �����ӿ� �ɸ��� �ð�) -> ��Ÿ Ÿ���� ���ϸ� ��� �̵��Ÿ��� ��������
        transform.position += Vector3.left * Time.deltaTime * speed;


            
    }
}
