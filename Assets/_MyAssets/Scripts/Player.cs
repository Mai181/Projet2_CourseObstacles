using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ***** Attributs *****
    
    [SerializeField] private float _vitesse = 800f;  //Vitesse de d�placement du joueur
    private Rigidbody _rb;  // Variable pour emmagasiner le rigidbody du joueur
    
    //  ***** M�thodes priv�es *****
    
    private void Start()
    {
        // Position initiale du joueur
        transform.position = new Vector3(-30f, 0.51f, -30f);  // place le joueur � sa position initiale 
        _rb = GetComponent<Rigidbody>();  // R�cup�re le rigidbody du Player
    }

    // Ici on utilise FixedUpdate car les mouvements du joueurs implique le d�placement d'un rigidbody
    private void FixedUpdate()
    {
        MouvementsJoueur();
    }

    /*
     * M�thode qui g�re les d�placements du joueur
     */
    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal"); // R�cup�re la valeur de l'axe horizontal de l'input manager
        float positionZ = Input.GetAxis("Vertical");  // R�cup�re la valeur de l'axe vertical de l'input manager
        Vector3 direction = new Vector3(positionX, 0f, positionZ);  // �tabli la direction du vecteur � appliquer sur le joueur
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;  // Applique la v�locit� sur le corps du joueur dans la direction du vecteur
        // _rb.AddForce(direction * Time.fixedDeltaTime * _vitesse);  // Applique une force sur le joueur dans la direction du vecteur
    }

    // ***** M�thodes publiques *****

    /*
     * M�thode appel� en fin de partie qui rend le gameObject Player inactif
     */
    public void finPartieJoueur()
    {
        gameObject.SetActive(false);  // D�sactive le gameObject
    }
}
