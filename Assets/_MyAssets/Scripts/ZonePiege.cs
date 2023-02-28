using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    private bool _estActive = false;
    [SerializeField] private GameObject _piege = default;
    private Rigidbody _rb;
    [SerializeField] private float _intensiteForce = 200;

    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive)
        {
            _rb.useGravity = true;
            Vector3 direction = new Vector3(0f, -1f, 0f);
            _rb.AddForce(direction * _intensiteForce);
            _estActive = true;
        }
    }
}
