using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3 : MonoBehaviour
{
 
   // Start is called before the first frame update
    void Update()
    {
        
         transform.Rotate (new Vector3 (-92, 0, 0) * Time.deltaTime);
         transform.Rotate (new Vector3 (-77, 0, 0) * Time.deltaTime);
    }

    
}
