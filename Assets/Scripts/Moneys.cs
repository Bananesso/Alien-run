using TMPro;
using TMPro.Examples;
using UnityEngine;

public class Moneys : MonoBehaviour
{
    public int MoneyValue;
    public static int MyCash;

    private void Start()
    {
        MyCash = PlayerPrefs.GetInt("Bank");
    }
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        MyCash += MoneyValue;
        PlayerPrefs.SetInt("Bank", MyCash);
        Destroy(gameObject);
    }

}