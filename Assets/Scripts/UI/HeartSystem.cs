using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    public int _vida;
    public int _vidaMaxima;

    public Image[] coracao;
    public Sprite cheio;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
        DeadState();
    }

    void HealthLogic()
    {
        if (_vida > _vidaMaxima)
        {
            _vida = _vidaMaxima;    
        }
        for (int i = 0; i < coracao.Length; i++)
        {
           
            

            
            if (i < _vida)
            {
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
            }
        }
    }

    public void DeadState() {
        if (_vida <= 0)
        {
            GetComponent<Player>().enabled = false;
            Destroy(gameObject, 0.5f);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
