using TMPro;
using UnityEngine;

public class UImoneys : MonoBehaviour
{
    public TextMeshProUGUI myCashShow;

    void Update()
    {
        myCashShow.text = "Cash: " + Moneys.MyCash;
    }
}