using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs

    private int _pointage;
    
    // M�thodes priv�es
    private void Start()
    {
        InstructionsDepart();
        _pointage= 0;
    }

    private static void InstructionsDepart()
    {
        Debug.Log("*** Course � obstacles");
        Debug.Log("Le but du jeu est d'atteindre la zone d'arriv�e le plus rapidement possible");
        Debug.Log("Chaque contact avec un obstable entra�nera une p�nalit�");
    }

    // M�thodes publiques
    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochages : " + _pointage);
    }

}
