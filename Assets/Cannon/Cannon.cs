using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using NUnit.Framework;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Cannon : MonoBehaviour
{
    private Transform Barrel;
    float angle = 0;
    public GameObject prefab;
    bool IsSummon =  true;
    float timer = 4;
    public int Power_scale = 0;
    private void Awake()
    {
        Barrel = GetComponent<Transform>();

    }
    private void Update()
    {
        SummonProjectile();
        Power_Tuning();
    }
    private void FixedUpdate()
    {

        Barrel.transform.rotation = UnityEngine.Quaternion.Euler(0,0,CannonLeverage());
        if (timer > 0)
        timer -=1*Time.deltaTime;

    }
    public float CannonLeverage()
    {
        float max_angle = 45;
        float turnSpeed = 5f;
        if(Keyboard.current.wKey.IsPressed() && angle <= max_angle)
        {
            angle += turnSpeed*Time.deltaTime;
    
        }
        if(Keyboard.current.sKey.IsPressed())
        {
            angle -= turnSpeed*Time.deltaTime;
    
        }
        return angle;
    }
   private void SummonProjectile()
    {
        if(Keyboard.current.spaceKey.IsPressed() && timer <= 0)
        {
            GameObject  bullet =  Instantiate(prefab, Barrel.transform.position,UnityEngine.Quaternion.Euler(Barrel.transform.eulerAngles + new UnityEngine.Vector3(0,0,-90)));
            Debug.Log("Summon");
            timer = 4;

    }
    }
    public float Get_time()
    {
        float time = timer;
        return time;
    }
    public int Power_Tuning()
    {
        if(Keyboard.current.upArrowKey.IsPressed() && Power_scale>=0)
        {
           Power_scale = Power_scale + 1;
           Debug.Log("UP");
        }
        
        if(Keyboard.current.downArrowKey.IsPressed() && Power_scale>=0)
        {
           Power_scale -= 1;
           Debug.Log("Down");
        }
        return Power_scale;
    }
}
