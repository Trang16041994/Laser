using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  
 
    public void DestroyGameObj()
    {
        Destroy(gameObject, 0.5f);
    }

    
}
