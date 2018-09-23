using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public bool status = true;
    public PlayerMovement player;
    //colide
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag.Equals("Collider"))
        {
            Debug.Log("Colidiu: " + collision.collider.tag);
            status = false;
        }
       
        if (!status)
        {
            player.enabled = false;
            Debug.Log("Você perdeu bundão");
            FindObjectOfType<GameManager>().GameOver();
            

        }

    }
    
}
