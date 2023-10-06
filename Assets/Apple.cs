using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float boundary= -20f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=boundary){
            Destroy(this.gameObject);

            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            apScript.AppleMissed();
        }
    }
}
