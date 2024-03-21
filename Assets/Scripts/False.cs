using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False : MonoBehaviour
{
    public float descentSpeed = 1.0f; // Velocidade de descida da parede

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartDescent());
    }

    // Update is called once per frame
    void Update()
    {
        // Move a parede para baixo com a velocidade especificada
        if(enabled){
            transform.Translate(Vector3.down * descentSpeed * Time.deltaTime);
            Debug.Log("Parede descendo");
        }
    }

    IEnumerator StartDescent()
    {
        yield return new WaitForSeconds(15.0f);
        enabled = true;
    }
}
