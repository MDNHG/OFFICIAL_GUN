using TMPro;
using UnityEngine;

public class UI_Testing : MonoBehaviour
{
    [SerializeField] private TextMeshPro UI;
    [SerializeField] private UIBackend backend;
    void Awake()
    {
    }
    void Update()
    {
        UI.text = "Time left" + backend.Return_Timer();
    }
}
