using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotate : MonoBehaviour
{
    [SerializeField] int rotSpeed = 1;
    void Update()
    {
        transform.Rotate(0,rotSpeed,0,Space.World);        
    }
}
