using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]

public class ColorChange : MonoBehaviour
{
    [SerializeField] MeshRenderer target;
    MeshRenderer srend;
    int step;
    [SerializeField] GameObject Test1;
    Animator Headphonesanimator;
    void Awake()
    {
        //srend = GetComponent<MeshRenderer>();
         Headphonesanimator = Test1.GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        step++;
        Headphonesanimator.SetInteger("step",step);
        //Debug.Log(gameObject.name);
        //target.material.color = srend.material.color;
    }
}
