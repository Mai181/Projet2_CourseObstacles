using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 10f;
    private Rigidbody _rb;
    
    //  M�thodes priv�es
    private void Start()
    {
        // Position initiale du joueur
        transform.position = new Vector3(-30f, 0.51f, -30f);
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }


    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        //transform.Translate(direction * Time.deltaTime * _vitesse);
        //_rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        _rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);
    }

    public void finPartieJoueur()
    {
        gameObject.SetActive(false);
    }
}
