using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppleTree : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject applePrefab;
    public float initVel= 1f;
    public float boundary= 5f;
    public float dropRate;
    public float changeRate;

    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple(){
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", dropRate);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += initVel*Time.deltaTime;

        if((pos.x-.001 <= boundary && boundary <= pos.x + .001) || (pos.x - .001 <= -boundary && -boundary <= pos.x + .001))
        {
            initVel *= -1;
        }


        
        transform.position = pos;

    }
}
