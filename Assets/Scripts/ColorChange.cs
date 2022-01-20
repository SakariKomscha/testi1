using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]

public class ColorChange : MonoBehaviour
{
    [SerializeField] MeshRenderer target;
    MeshRenderer srend;

    void Awake()
    {
        srend = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        target.material.color = srend.material.color;
    }
}
