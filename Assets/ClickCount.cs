using UnityEngine;
using UnityEngine.UI;


public class ClickCount : MonoBehaviour
{
 
    public Text priceball;
    public Text multiplyball;
    public int price1;
    public int multiply1;
    public UnityEngine.UI.Button shotupgrade;
    public gamemanager score;
   
  

    private void Start()
    {
        price1 = 10;
        multiply1 = 1;
        show();
        shotupgrade.onClick.AddListener(Pressedball);
    }
    void Pressedball()
    {
        if (score.budget >= price1)
        {
            multiply1++;
            score.budget = score.budget - price1;
            price1 = price1 + 15;          
            score.showscore();
            show();
        }
    }
    public void resetfunction()
    {
        price1 = 10;
        multiply1 = 1;
        show();
    }
    void show()
    {
        priceball.text = "Cena: " + price1.ToString();
        multiplyball.text ="x" + multiply1.ToString();
    }


    void OnMouseDown()
    {
        score.addscore(multiply1);
    }

    
}
