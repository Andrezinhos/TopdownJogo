using UnityEngine;
using UnityEngine.InputSystem;

public class Personagem : MonoBehaviour
{
    Rigidbody2D rigib;

    float horizontal;
    float vertical;
    
    public float velo = 5;

    bool estaDialogo = false;

    void Start()
    {
        rigib = transform.GetComponent<Rigidbody2D>();
        rigib.rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!estaDialogo)
        {
            ProcessaInputs();
        }
        Dialogo();
    }

    void FixedUpdate()
    {
        MoveJogador();
        RotacionarMovimento();
        //RotacionaMouse();
    }

    void ProcessaInputs()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void MoveJogador()
    {
        Vector2 move = new Vector2(horizontal, vertical);
        if (move.magnitude > 1)
        {
            move = move.normalized;
        }
        move = move * velo;

        rigib.linearVelocity = move;
    }

    void RotacionarMovimento()
    {
        //return early
        if (vertical == 0 && horizontal == 0)
        {
            return;
        }

        float angulo = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;
        rigib.rotation = angulo;
    }

    void RotacionaMouse()
    {
        Vector3 posMundiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Utils.OlharParaObjeto(transform, posMundiMouse);
    }

    void Dialogo()
    {
        if (Input.GetKey(KeyCode.F))
        {
            estaDialogo = true;
            Utils.OlharParaObjeto(transform, GameObject.Find("NPC").gameObject.transform.position);
        }
        if (Input.GetKey(KeyCode.G) && estaDialogo == true)
        {
            estaDialogo = false;
            return;
        }
    }
}