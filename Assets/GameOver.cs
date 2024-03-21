using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject restartButton;
    public GameObject gameOverTextObject;
    public GameObject menuButton;
    void Start()
    {
        gameOverTextObject.SetActive(false);
        restartButton.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {   
        BoxCollider boxCollider = player.GetComponent<BoxCollider>();
        if(boxCollider != null)
        {
            boxCollider.isTrigger = true;
        }
        gameOverTextObject.SetActive(true);
        restartButton.SetActive(true);
        menuButton.SetActive(true);

    }
}

}
