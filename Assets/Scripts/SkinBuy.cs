using UnityEngine;

public class SkinBuy : MonoBehaviour
{
    public GameObject menu;
    public GameObject skin;
    public int price;

    public void skinChange()
    {
        if (PlayerPrefs.GetInt("Bank", Moneys.MyCash) >= PlayerPrefs.GetInt("Price", price))
        {
            menu.gameObject.SetActive(false);
            skin.gameObject.SetActive(true);
            PlayerPrefs.SetInt("Bank", Moneys.MyCash -= PlayerPrefs.GetInt("Price", price));
            PlayerPrefs.SetInt("Price", price = 0);
        }
    }
}