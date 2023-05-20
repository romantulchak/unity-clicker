using System;
using System.Collections;
using System.Collections.Generic;
using Model;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public void Start()
    {
        LoadLevel();
    }

    public void ClickOnArea()
    {
        Debug.Log("Click");
    }

    private void LoadLevel()
    {
        var levelImage = Resources.Load<Texture2D>("Game/Levels/level1");
        var platform = GameObject.FindWithTag("Platform").GetComponent<Image>();
        platform.sprite = Sprite.Create(levelImage, new Rect(0, 0, levelImage.width, levelImage.height), Vector2.zero);
    }

    private void LoadMonster()
    {
        var currentMonster = new Monster("test", 100, "monster1");
        
    }
}
