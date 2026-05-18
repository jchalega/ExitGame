using UnityEngine;
using UnityEngine.UI;

public class HeartHUD : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public Image[] coracao;

    void Update()
    {
        healthLogic();
        
    }
    public void healthLogic()
    {
        if (playerHealth == null)
            return;
        for (int i = 0; i < coracao.Length; i++)
        {
            if (i < playerHealth.vida)
            {
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
            }
        }
    }

    
}