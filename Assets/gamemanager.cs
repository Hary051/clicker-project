
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public double budget = 0;
    public double alltimegoals = 0;
    public Text budget1;
    public Text alltimegoals1;
    public double resetbonus=1;
    

        public void addscore(int kolik)
        {
            budget = budget + kolik*resetbonus;
            alltimegoals = alltimegoals + kolik*resetbonus;
            showscore();
        }

        public void showscore()
        {
            alltimegoals1.text = "CELKOVÝ POÈET GÓLÙ: " + alltimegoals.ToString();
            budget1.text = "ROZPOÈET: " + budget.ToString();
        }

    
}
