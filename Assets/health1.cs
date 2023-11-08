using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class health1 : MonoBehaviour
{
    public int maxHealth = 3;
    public int CurrentHealth;
    void Start()
    {
        CurrentHealth = maxHealth;
    }

    // Update is called once per frame
}
