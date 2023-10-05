using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps = default;

    private GestionJeu _gestionJeu;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtAccrochages.text = "Accrochages : " + _gestionJeu.GetPointage().ToString();
    }

    private void Update()
    {
        float temps = Time.time - _gestionJeu.TempsDepart;
        _txtTemps.text = "Temps : " + temps.ToString("f2");
    }

    public void ChangerPointage(int nouveauPointage)
    {
        _txtAccrochages.text = "Accrochages : " + nouveauPointage;
    }

}
