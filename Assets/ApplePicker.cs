using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float yOff = 1.4f;
    public float yBot = -10f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
       for(int i =0; i< numBaskets; i++){
            GameObject basketLayer = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = yBot + i*yOff;
            basketLayer.transform.position = pos;
            basketList.Add(basketLayer);
        } 
    }

    public void AppleMissed(){
        GameObject[] appleArray=GameObject.FindGameObjectsWithTag("Apple");

        foreach( GameObject tempGo in appleArray){
            Destroy( tempGo);
        }
    
        int basketIndex = basketList.Count -1;

        GameObject basketGo = basketList[basketIndex];

        basketList.RemoveAt(basketIndex);
        Destroy(basketGo);

        if(basketList.Count == 0){
            SceneManager.LoadScene( "_Scene_0" );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
