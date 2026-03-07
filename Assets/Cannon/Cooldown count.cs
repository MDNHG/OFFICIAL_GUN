using TMPro;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.UI;

public class Cooldowncount : MonoBehaviour
{
    [SerializeField] private TextMeshPro cooldown;
    Cannon cannon;
    void Awake()
    {
        cannon = GetComponentInParent<Cannon>();
    }
   void Update()
    {
        cooldown.text = "Reload time" + cannon.Get_time();     
    }
}
