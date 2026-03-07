using UnityEngine;

public class UIBackend : MonoBehaviour
{
    
    float timer = 4f;   
    void Start()
    {
        
    }

    void Update()
    {
        timer -= 1*Time.deltaTime;
    }
    public float Return_Timer()
    {
        return timer;
    }
}
