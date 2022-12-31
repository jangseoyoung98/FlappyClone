using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MakePipe : MonoBehaviour
{
    public GameObject pipe;

    public float timeDiff;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe;
            newpipe = Instantiate(pipe); // pregfab을 찍어낸다.
                
            // Random.Range(min, max)를 사용해서 파이프의 위치를 랜덤하게 출력한다.
            float random_x = Random.Range(0.3f, 2.5f);
            float random_y = Random.Range(0.5f, 3f);
            // float random_z = Random.Range(-10f, 10f); -> 2D에서 z축은 티가 안 나는 걸까..쓰이지 않는 걸까..?
            
            newpipe.transform.position = new Vector3(random_x, random_y, 0); // 유니티 에디터의 transform의 position을 변경해 준다.

            Destroy(newpipe, 10.0f);

            timer = 0;
        }
    }
}
