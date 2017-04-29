using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

    public Text timeLabel;
    float timer = 0.0f;
    int flag = 0;
    public GameObject mainpumpkin,pumpkin1,pumpkin2,particle1,particle2;

    // Use this for initialization
    void Start() {
        timeLabel.text = "PumpkinGame";
    }

    // Update is called once per frame
    void Update() {
        if (flag == 1)
        {
            timer += Time.deltaTime;
            timeLabel.text = timer.ToString("f1");
            transform.localScale = new Vector3(1, 1, 1) * timer;
        }
        if (15.0f < timer) {
            flag = 0;
            mainpumpkin.SetActive(false);
            timeLabel.text = "GameOver";
        }
        
   }

    public void StartButton() {
        flag = 1;
        timer = 0.0f;

        timeLabel.color = Color.white;

        mainpumpkin.SetActive(true);
        particle1.SetActive(false);
        particle2.SetActive(false);
        pumpkin1.SetActive(false);
        pumpkin2.SetActive(false);
    }
    public void StopButton() {
        flag = 0;
        if (9.95f < timer && timer < 10.05f)
        {
            timeLabel.text = "Happy Halloween!";
            timeLabel.color = new Color(144, 0, 255);
            pumpkin1.SetActive(true);
            pumpkin2.SetActive(true);
            particle1.SetActive(true);
            particle2.SetActive(true);
        }
        timer = 0.0f;
    }
}
