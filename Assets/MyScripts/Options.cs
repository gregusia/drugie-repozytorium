using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;

public class CharacterOption : MonoBehaviour
{
    public int id;
    public CharacterManager characterManager;

    public void OnClick()
    {
        characterManager.CharacterClicked(id);
    }
}
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
