using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoretext;
    public int point=0;
    void Start()
    {
        scoretext.text= point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = point.ToString();
    }
    public void Collectcherry()
    {
        point++;
    }
}
