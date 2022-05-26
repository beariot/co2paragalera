using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{  
    private SpriteRenderer sprite;
    private CircleCollider2D collider;

    public GameObject coletado;

    public int Pontos; 

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CircleCollider2D>();
    }

      //cria metodo para detectar colisao   
   void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {   
            sprite.enabled = false; 
            collider.enabled = false; 

            coletado.SetActive(true);

            //chama o metodo da classe fruit para armazenar o pontos acumulados  
            SavePoint.acesso.totalPontos += Pontos;

            SavePoint.acesso.atualizaPontosText();
 
            Destroy(gameObject, 0.4f);
        }
    }
}