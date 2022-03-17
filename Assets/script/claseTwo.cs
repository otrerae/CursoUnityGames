using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class claseTwo : MonoBehaviour
{

    public Vector3 unVector3;
    public float speedZ;
    public int scaleCharacter = 15;

    public int myLife = 100;
    public int Speed;
    public int Direction;
    public int Damage;
    public int Movement;
    public int Health;

    // Start is called before the first frame update
    void Start()
    {
        unVector3 = new Vector3(1, 1, 4);
        transform.localScale = new Vector3(transform.localScale.x * 10, transform.localScale.y, transform.localScale.z *10);
        movimiento();
        vida();
        Dano();

    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,speedZ/10);
    }
    void movimiento()
    {


    }

    void vida()
    {
        Health = myLife++;


    }

    void Dano()
    {

        Damage = myLife--;

    }
}
