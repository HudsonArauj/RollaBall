using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEsfera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BigEsferaPrefab;
    public float speed = 20f; 
    public float spawnInterval = 5f; 
    public Vector3 spawnPosition = new Vector3(-203, 20, -168); 

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnCilindrosRepeatedly());
    }

    private IEnumerator SpawnCilindrosRepeatedly()
    {
        
        while (true)
        {
            GameObject newBigEsfera = Instantiate(BigEsferaPrefab, spawnPosition, Quaternion.identity);

            Rigidbody rb = newBigEsfera.AddComponent<Rigidbody>();

            rb.velocity = Vector3.down * speed;
            rb.velocity = Vector3.right * speed;
            Destroy(newBigEsfera, 5f);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
