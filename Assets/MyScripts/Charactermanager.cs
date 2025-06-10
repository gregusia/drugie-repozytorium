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
        SetupCharacters(); // aby przy starcie sceny wype³ni³o siê UI przygotowanymi elementami w tablicy characterSprites
        CharacterClicked(0);//ustawienie bia³ego elementu Aliena na start
    }

    void SetupCharacters()
    {
        for (int i = 0; i < characterSprites.Length; i++) //przejscie po rozmiarze tablicy zawierajacej wszystkich przygotowanych bohaterow
        {
             //Instantiate(characterOptionPrefab, characterContainer); // to spowoduje wype³nienie (sklonowanie) pierwszego elementu tablicy tyle razy ile jest obiektow w tablicy charaktersprites 

            GameObject go = Instantiate(characterOptionPrefab, characterContainer);
            CharacterOption characterOption = go.GetComponent<CharacterOption>(); // aby uzysakæ dostêp do metod obiektu characterOptions
            //characterOption.Initialized(this, i);
            //characterOption.enabled = true;


            //GameObject go = Instantiate(characterOptionPrefab, charactersContainer);
            //CharacterOption characterOption = go.GetComponent<CharacterOption>();
            //characterOption.Initialize(this, i);
        }
    }
}
