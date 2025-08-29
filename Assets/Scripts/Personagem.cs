using UnityEngine;

public class Personagem : MonoBehaviour
{
    Rigidbody2D rigib;

    float horizontal;
    float vertical;

    public float velo = 5;

    void Start()
    {
        rigib = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessaInputs();
    }

    void FixedUpdate()
    {
        MoveJogador();
    }

    void ProcessaInputs()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void MoveJogador()
    {
        rigib.linearVelocity += new Vector2(horizontal, vertical) * velo;
    }
}