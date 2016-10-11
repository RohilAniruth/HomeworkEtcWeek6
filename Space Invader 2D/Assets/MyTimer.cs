using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyTimer : MonoBehaviour
{
    public float myCoolTimer = 30;
    public Text timerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        myCoolTimer -= Time.deltaTime;
        timerText.text = myCoolTimer.ToString("f0");
        print("myCoolTimer");

    }
}
