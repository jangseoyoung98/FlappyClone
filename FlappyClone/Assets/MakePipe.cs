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
            newpipe = Instantiate(pipe); // pregfab�� ����.
                
            // Random.Range(min, max)�� ����ؼ� �������� ��ġ�� �����ϰ� ����Ѵ�.
            float random_x = Random.Range(0.3f, 2.5f);
            float random_y = Random.Range(0.5f, 3f);
            // float random_z = Random.Range(-10f, 10f); -> 2D���� z���� Ƽ�� �� ���� �ɱ�..������ �ʴ� �ɱ�..?
            
            newpipe.transform.position = new Vector3(random_x, random_y, 0); // ����Ƽ �������� transform�� position�� ������ �ش�.

            Destroy(newpipe, 10.0f);

            timer = 0;
        }
    }
}
