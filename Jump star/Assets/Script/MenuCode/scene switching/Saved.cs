using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saved : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
    }
}
