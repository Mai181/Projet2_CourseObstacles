using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] private float _vitesseRotation = 0.5f;
        
    void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseRotation, 0f);
    }
}
