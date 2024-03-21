using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public GameObject cilindroPrefab;
    public float speed = 20f; 
    public float spawnInterval = 5f; 
    public Vector3 spawnPosition = new Vector3(-93, 47, 75); 

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnCilindrosRepeatedly());
    }

    private IEnumerator SpawnCilindrosRepeatedly()
    {
        
        while (true)
        {
            GameObject newCilindro = Instantiate(cilindroPrefab, spawnPosition, Quaternion.Euler(0, 0, 90));

            Rigidbody rb = newCilindro.AddComponent<Rigidbody>();

            rb.velocity = -Vector3.forward * speed;
            Destroy(newCilindro, 5f);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
