using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameWin : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject wingame;
    public GameObject winTextObject;
    public float totalTime = 60f;
    private float timeLeft;
     public TextMeshProUGUI timeText;
    public Button restartButton;
    public Button menuButton;

    void Start()
    {
        winTextObject.SetActive(false);
        timeLeft = totalTime;
        restartButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            wingame.GetComponent<BoxCollider>().isTrigger = true;
            winTextObject.SetActive(true);
            timeLeft = 0;
            timeText.text = "Tempo : " + timeLeft;
            restartButton.gameObject.SetActive(true);
            menuButton.gameObject.SetActive(true);
        }
    }
}
