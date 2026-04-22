using UnityEngine;
using System;
using TMPro;

public class AgeCalculator : MonoBehaviour
{
    public TMP_InputField inputName;
    public TMP_InputField inputYear;
    public TMP_Text textResult;

    public void CalculateAge()
    {
        // Ievade
        string name = inputName.text.Trim();
        string yearStr = inputYear.text.Trim();

        // Pârbaude, vai viss ir aizpildîts
        if (string.IsNullOrEmpty(name))
        {
            textResult.text = "Ievadi tçla vârdu!";
            return;
        }
        if (string.IsNullOrEmpty(yearStr))
        {
            textResult.text = "Ievadi dzimðanas gadu!";
            return;
        }

        // Pârbauda, vai gads ir skaitlis
        if (!int.TryParse(yearStr, out int birthYear))
        {
            textResult.text = "Dzimðanas gadam jâbût skaitlim!";
            return;
        }

        // Iegûst paðreizçjo gadu
        int currentYear = DateTime.Now.Year;

        // Aprçíina vecumu
        int age = currentYear - birthYear;

        // Rezultâts piemçram: "Supervaronis Oskars ir 25 gadus vecs!"
        textResult.text = $"Supervaronis {name} ir {age} gadus vecs!";
    }
}