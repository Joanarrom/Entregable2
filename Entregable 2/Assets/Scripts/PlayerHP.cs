using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private bool gameOver;
   
    private int HP = 100;
    public int damage = 30;
    // Start is called before the first frame update
    void Start()
    {
        void Start()
        {
            HP = HP - damage;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {

            if (HP <= 0)
            {

                Debug.Log(message: "GAME OVER, se te acabo el chollo amigo");
            }
            else
            
            if (HP < 70)
            {


                Debug.Log(message: "Cuidado gentuzo, que te mueres");
            }
            else
            if (HP < 20)
            {

                Debug.Log(message: $"Aun tienes bastante vida, {HP} lifepoints");
            }
        }
        else if (HP = 0)
        {
            Debug.Log(message: "El juego ha finalizado");
        }
    }
}
