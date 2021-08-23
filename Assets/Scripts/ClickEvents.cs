using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvents : MonoBehaviour
{

    private List<string> items = new List<string>();
    private int index;
    private int currentIndex;

    private bool appleBool, astronautBool, sunBool, starBool, teacherBool, turtleBool, doorBool, dogBool, elephantBool, shoeBool, shirtBool, shipBool;

    //public GameObject moonTriggerBox, appleTriggerBox, astronautTriggerBox, sunTriggerBox, starTriggerBox, teacherTriggerBox, turtleTriggerBox, doorTriggerBox, dogTriggerBox, elephantTriggerBox, shoesTriggerBox, shirtTriggerBox, shipsTriggerBox;
    public GameObject[] itemTriggers;

    public GameObject moonGO, appleGO, astronautGO, sunGO, starGO, teacherGO, turtleGO, doorGO, dogGO, elephantGO, shoesGO, shirtGO, shipsGO;
    public GameObject coloredBg;

    private void Start()
    {
        items = GameManager._instance.items;
        index = GameManager._instance.index;

        StartCoroutine(SoundPlay(1.0f));
    }

    public void ClickMoon()
    {
        //if (items[index].Equals("Moon"))
        //{
        //    moonGO.SetActive(true);
        //    index++;
        //}
        //index++;
        moonGO.SetActive(true);
        //itemTriggers[currentIndex].SetActive(false);
        MoveToNextItem();
        SoundManager._instance.aSoundPlay();
    }

    public void ClickApple()
    {
        appleGO.SetActive(true);

        appleBool = true;
        if (appleBool && astronautBool )
        {
            MoveToNextItem();
            SoundManager._instance.sSoundPlay();
        }
    }

    public void ClickAstronaut()
    {
        astronautGO.SetActive(true);

        astronautBool = true;
        if (appleBool && astronautBool)
        {
            MoveToNextItem();
            SoundManager._instance.sSoundPlay();
        }
    }

    public void ClickSun()
    {
        sunGO.SetActive(true);

        sunBool = true;
        if (sunBool && starBool)
        {
            MoveToNextItem();
            SoundManager._instance.tSoundPlay();
        }
    }

    public void ClickStar()
    {
        starGO.SetActive(true);
        starBool = true;
        if (sunBool && starBool)
        {
            MoveToNextItem();
            SoundManager._instance.tSoundPlay();
        }
    }

    public void ClickTeacher()
    {
        teacherGO.SetActive(true);
        teacherBool = true;
        if (teacherBool && turtleBool)
        {
            MoveToNextItem();
            SoundManager._instance.dSoundPlay();
        }
    }

    public void ClickTurtle()
    {
        turtleGO.SetActive(true);
        turtleBool = true;
        if (turtleBool && teacherBool)
        {
            MoveToNextItem();
            SoundManager._instance.dSoundPlay();
        }
    }

    public void ClickDoor()
    {
        doorGO.SetActive(true);
        doorBool = true;
        if (doorBool && dogBool)
        {
            MoveToNextItem();
            SoundManager._instance.eSoundPlay();
        }
    }

    public void ClickDog()
    {
        dogGO.SetActive(true);
        dogBool = true;
        if (doorBool && dogBool)
        {
            MoveToNextItem();
            SoundManager._instance.eSoundPlay();
        }
    }

    public void ClickElephant()
    {
        elephantGO.SetActive(true);
        elephantBool = true;
        if (elephantBool)
        {
            MoveToNextItem();
            SoundManager._instance.shSoundPlay();
        }
    }

    public void ClickShoe()
    {
        shoesGO.SetActive(true);
        shoeBool = true;
        if (shoeBool && shirtBool && shipBool)
        {
            MoveToNextItem();
            coloredBg.SetActive(true);
        }
    }

    public void ClickShirt()
    {
        shirtGO.SetActive(true);
        shirtBool = true;
        if (shoeBool && shirtBool && shipBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }

    public void ClickShip()
    {
        shipsGO.SetActive(true);
        shipBool = true;
        if (shoeBool && shirtBool && shipBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }

    IEnumerator coloredBgShow(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        coloredBg.SetActive(true);
    }



    IEnumerator SoundPlay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SoundManager._instance.mSoundPlay();
    }

    public void MoveToNextItem()
    {
        currentIndex++;
        for (int i = 0; i < itemTriggers.Length; i++)
        {
            //if(itemTriggers[i])
            itemTriggers[i].SetActive(i == currentIndex);
        }
    }
}
