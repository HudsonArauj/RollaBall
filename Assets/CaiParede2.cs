using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaiParede2 : MonoBehaviour
{
    public GameObject parede;
    private bool destruida = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!destruida && parede.transform.position.y < -60)
        {

            Destroy(parede);
            destruida = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            parede.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
}
