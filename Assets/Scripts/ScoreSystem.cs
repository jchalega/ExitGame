using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int hamburgers;

    public void AddHamburger(int amount)
    {
        hamburgers += amount;
    }
}
