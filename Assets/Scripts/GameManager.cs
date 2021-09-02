using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> items = new List<string>()
    {
        "Moon",
        "Apple",
        "Astronaut",
        "Sun",
        "Star",
        "Teacher",
        "Turtle",
        "Telephone",
        "Door",
        "Dog",
        "Elephant",
        "Egg",
        "Shoes",
        "Shirt",
        "Ship",
        "Shark"
    };

    public int index;

    public static GameManager _instance;

    private void Awake()
    {
        _instance = this;

    }


}
