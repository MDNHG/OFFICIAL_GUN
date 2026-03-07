using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshPro powerCount;
    [SerializeField] private Cannon cannon;
    void Start()
    {
    }

    void Update()
    {
        powerCount.text = "Power: " + cannon.Power_Tuning();
    }
}
