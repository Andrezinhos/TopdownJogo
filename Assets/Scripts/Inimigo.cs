using UnityEngine;

public class Inimigo : MonoBehaviour
{
    Transform alvo;
    public float velo = 5;
    public int vidas = 3;

    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;    
    }

    void Update()
    {
        if (alvo == null)
        {
            return;
        }

        if (Vector2.Distance(transform.position, alvo.position) < 1.25)
        {
            return;
        }

        Vector3 direcao = alvo.position - transform.position;
        direcao = direcao.normalized;

        transform.position += direcao * velo * Time.deltaTime;

    }

    public void ReceberDano(int dano)
    {
        vidas -= dano; 
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }
}
