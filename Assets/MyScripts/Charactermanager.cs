using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;


public class CharacterManager : MonoBehaviour
{
    public Image previewImage;
    public Sprite[] characterSprites;

    public Image PreviewImage { get => previewImage; set => previewImage = value; }

    public void CharacterClicked(int id)
    {
        previewImage.sprite = characterSprites[id];
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
