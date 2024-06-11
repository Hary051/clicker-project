
using UnityEngine;
using UnityEngine.UI;

public class reset : MonoBehaviour
{
    public Text current;
    public Text available;
    public int current2=1;
    public double available1;
    public int available2;
    public int requiredforreset;
    public gamemanager score;
    public passiveincomeobjects shoes;
    public passiveincomeobjects tshirt;
    public passiveincomeobjects stadium;
    public passiveincomeobjects trophy;
    public ClickCount click;
    private void Start()
    {
        current.text = "souèasný bonus: " + 1 + "x";
        available.text= "bonus v pøípadì resetu: "+1 + "x";
        resetbutton.onClick.AddListener(pressedreset);
    }
    public Button resetbutton;
    public void Update()
    {
        current.text = "souèasný bonus: " + current2.ToString() + "x";
        available1 = score.alltimegoals/requiredforreset+current2;
        available2 = (int)available1;
        available.text = "bonus v pøípadì resetu: " + available2.ToString() +"x";      
    }

    public void pressedreset()
    {
        
        if (score.alltimegoals>=requiredforreset) 
        {
            score.resetbonus = available2;
            score.alltimegoals = 0;
            score.budget = 0;
            current2 = available2;
            shoes.resetfunction();
            tshirt.resetfunction();
            stadium.resetfunction();
            trophy.resetfunction();
            click.resetfunction();
        }
    }
}
