using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Text textElementScore;
    public Text textElementOrder;
    static public string textScore;
    static public string textOrder;
    void Update()
    {
        textScore = "" + ItemSystem.score.ToString();
        textOrder = "Order : " + ItemSystem.orderList;

        textElementScore.text = textScore;
        textElementOrder.text = textOrder;
    }
}