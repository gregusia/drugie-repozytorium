using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;

public class CharacterOption : MonoBehaviour
{
    public int id;
    public CharacterManager characterManager;
    public Image characterImage;
   
    public void OnClick()
    {
     
        characterManager.CharacterClicked(id);

        Debug.Log("Nacisnieto "+ id);
    }

    public void Initialized(CharacterManager characterManager, int id) //aby zainicjowac odpowiednio tabele spritow 
    {
        this.characterManager = characterManager;
        this.id = id;
        characterImage.sprite = characterManager.characterSprites[id];
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
