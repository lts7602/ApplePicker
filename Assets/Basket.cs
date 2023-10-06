using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");

        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse2D = Input.mousePosition;
        mouse2D.z = -Camera.main.transform.position.z;
        Vector3 mouse3D = Camera.main.ScreenToWorldPoint(mouse2D);

        Vector3 pos = this.transform.position;
        pos.x = mouse3D.x;
        transform.position = pos;
    }

    void OnCollisionEnter( Collision coll){
        GameObject collidedWith = coll.gameObject;
        if( collidedWith.CompareTag("Apple")){
            Destroy(collidedWith);
            scoreCounter.score +=100;
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
        }
    }
    
}
