using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Image[] lives;
    public Sprite live;
    public Sprite empty;
    public int health = 3;
    
    private void FixedUpdate()
    {
        for (int i = 0; i < lives.Length; i++) 
        {
            if (i < health)
            {
                lives[i].sprite = live;
            }
            else
            {
                lives[i].sprite = empty;
            }
        }
    }
    public void Hit()
    {
        health -= 1;
        if (health < 0 )
        {
            Destroy(gameObject);
        }
    }
}
