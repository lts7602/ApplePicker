using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score=0;

    private TMP_Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText= GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString( "#,0");
    }
}
