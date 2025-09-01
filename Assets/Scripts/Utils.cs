using UnityEngine;

public class Utils : MonoBehaviour
{
    /// <summary>
    /// Objeto de origem que for referenciado irá seguir o objeto-alvo
    /// </summary>
    /// <param name="origem"> QUEM vai seguir</param>
    /// <param name="objeto"> QUEM será seguido</param>
    public static void OlharParaObjeto(Transform origem, Vector3 objeto)
    {
        Vector3 direcao = (objeto - origem.position).normalized;

        float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;

        if (origem.GetComponent<Rigidbody2D>())
        {
            origem.GetComponent<Rigidbody2D>().rotation = angulo;
        }
        else
        {
            origem.eulerAngles = new Vector3(0, 0, angulo);
        }
    }
}
