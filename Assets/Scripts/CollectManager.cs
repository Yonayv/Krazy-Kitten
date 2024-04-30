using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CollectManager : MonoBehaviour
{

    public int collectiblesCount;
    public TextMeshProUGUI pointText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points:" + collectiblesCount.ToString();
    }
}
