using UnityEngine;

public class Gates : MonoBehaviour
{
    public float playerSizeEdit;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            other.transform.localScale += new Vector3(playerSizeEdit, playerSizeEdit, playerSizeEdit); 
        }
    }

}