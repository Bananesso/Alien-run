using UnityEngine;

public class Gates : MonoBehaviour
{
    public GameObject player;
    public float playerSizeEdit;
    void OnTriggerEnter(Collider other)
    {
        player = GameObject.FindWithTag("Player");
    }
    private void OnTriggerExit(Collider other)
    {
        player.transform.localScale += new Vector3(playerSizeEdit, playerSizeEdit, playerSizeEdit);
    }
}