using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 10f;
    
    //  Méthodes privées
    private void Start()
    {
        // Position initiale du joueur
        transform.position = new Vector3(-30f, 0.51f, -30f);
    }

    private void Update()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
