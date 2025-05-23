using UnityEngine;

public class Velocidade : MonoBehaviour
{
    public float velocidade = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = 0f;
        if (Input.GetKey(KeyCode.D)) { movimentoHorizontal = 1f; }
        else if (Input.GetKey(KeyCode.A)) { movimentoHorizontal = -1f; }
        else { movimentoHorizontal = 0f; }
        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;
    }
}
