using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalHamburgers;
    public int hamburgersCollected;

    public GameObject portal;
    public GameObject mensagemPortal;

    void Start()
    {
        portal.SetActive(false);
        mensagemPortal.SetActive(false);
    }

    public void CollectHamburger()
    {
        hamburgersCollected++;

        if (hamburgersCollected >= totalHamburgers)
        {
            portal.SetActive(true);
            mensagemPortal.SetActive(true);
        }
    }
}