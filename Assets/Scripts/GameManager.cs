using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject esferaPrefab;
    public float speed = 5f; 
    public float spawnInterval = 2f; 
    public Vector3 spawnPosition = new Vector3(-9, 70, 5); 

    public Vector3 spawnPosition2 = new Vector3(8, 59, 71); 

    public Vector3 spawnPosition3 = new Vector3(-99, 45, 79); 

    public Vector3 spawnPosition4 = new Vector3(-90, 45, 79);

    public Vector3 spawnPosition5 = new Vector3(-85, 45, 79);

    public Vector3 spawnPosition6 = new Vector3(-183, 13, -168);

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnEsferasRepeatedly());
    }

    private IEnumerator SpawnEsferasRepeatedly()
    {
        
        while (true)
        {
            int x = Random.Range(-196, -85); 
            spawnPosition6 = new Vector3(x, 13, -168); 
       
            GameObject newEsfera = Instantiate(esferaPrefab, spawnPosition, Quaternion.identity);
            GameObject newEsfera2 = Instantiate(esferaPrefab, spawnPosition2,Quaternion.identity);
            GameObject newEsfera3 = Instantiate(esferaPrefab, spawnPosition3,Quaternion.identity);
            GameObject newEsfera4 = Instantiate(esferaPrefab, spawnPosition4,Quaternion.identity);
            GameObject newEsfera5 = Instantiate(esferaPrefab, spawnPosition5,Quaternion.identity);
            GameObject newEsfera6 = Instantiate(esferaPrefab, spawnPosition6,Quaternion.identity);

       
            Rigidbody rb = newEsfera.AddComponent<Rigidbody>();
            Rigidbody rb2 = newEsfera2.AddComponent<Rigidbody>();
            Rigidbody rb3 = newEsfera3.AddComponent<Rigidbody>();
            Rigidbody rb4 = newEsfera4.AddComponent<Rigidbody>();
            Rigidbody rb5 = newEsfera5.AddComponent<Rigidbody>();
            Rigidbody rb6 = newEsfera6.AddComponent<Rigidbody>();

            rb.velocity = Vector3.right * speed;
            rb2.velocity = Vector3.left * speed;
            rb3.velocity = -Vector3.forward * speed;
            rb4.velocity = -Vector3.forward * speed;
            rb5.velocity = -Vector3.forward * speed;
            rb6.velocity = -Vector3.forward * speed;
            Destroy(newEsfera, 5f);
            Destroy(newEsfera2,10f);
            Destroy(newEsfera3,10f);
            Destroy(newEsfera4,10f);
            Destroy(newEsfera5,10f);
            Destroy(newEsfera6,5f);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
