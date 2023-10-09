using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AffichageFinal : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtResultatFinal = default;

    private GestionJeu _gestionJeu;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        float tempsFinal = Time.time;
        int accrochages = _gestionJeu.GetPointage();
        float resultatfinal = tempsFinal + accrochages;
        _txtTempsTotal.text = "Temps Total : " + tempsFinal.ToString("f2");
        _txtAccrochages.text = "Accrochages : " + accrochages;
        _txtResultatFinal.text = "Résultat Final : " + resultatfinal.ToString("f2");
    }

    
}
