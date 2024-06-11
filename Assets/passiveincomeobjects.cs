using UnityEngine;
using UnityEngine.UI;


public class passiveincomeobjects : MonoBehaviour
{
    public int startprice;
    int price;
    public int multiply;
    public Text multiplytext;
    public Text pricetext;
    public float timer;
    public gamemanager score;
    public int passiveincome;
    public UnityEngine.UI.Button upgrade;
    public int priceadd;
    public int addamount;
    public reset reset;

    

    private void Start()
    {
        upgrade.onClick.AddListener(Pressed);       
        price = startprice;
        show();
    }
    void show()
    {
        pricetext.text = "Cena: " + price.ToString();
        multiplytext.text = addamount.ToString() + "x" + multiply.ToString();
    }

    void Pressed()
    {
        if (score.budget >= price)
        {
            multiply++;         
            score.budget = score.budget - price;
            price = price + priceadd;
            passiveincome = passiveincome + addamount;
            score.showscore();
            show();
        }
    }
    public void resetfunction() 
    {
        price = startprice;
        multiply = 0;
        passiveincome = 0;
        show();
    }
    public void Update()
    {
     
        if (true)
        {
            timer += Time.deltaTime;
            if (timer > 1)
            {
                score.addscore(passiveincome);
                timer = 0;
            }

        }


    }
}
