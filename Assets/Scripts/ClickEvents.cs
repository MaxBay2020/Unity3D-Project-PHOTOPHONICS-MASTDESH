using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvents : MonoBehaviour
{

    private List<string> items = new List<string>();
    private int index;
    private int currentIndex;

    private bool appleBool, astronautBool, sunBool, starBool, sharkBool, teacherBool, turtleBool, telephoneBool, doorBool, dogBool, elephantBool, eggBool, shoeBool, shirtBool, shipBool;

    //public GameObject moonTriggerBox, appleTriggerBox, astronautTriggerBox, sunTriggerBox, starTriggerBox, teacherTriggerBox, turtleTriggerBox, doorTriggerBox, dogTriggerBox, elephantTriggerBox, shoesTriggerBox, shirtTriggerBox, shipsTriggerBox;
    public GameObject[] itemTriggers;
    public GameObject[] hints;

    public GameObject moonGO, appleGO, astronautGO, sunGO, starGO, sharkGO, teacherGO, turtleGO, telephoneGO, doorGO, dogGO, elephantGO, eggGO, shoesGO, shirtGO, shipsGO;
    public GameObject coloredBg;

    public GameObject letterBox;
    public Sprite mLetter, aLetter, sLetter, tLetter, dLetter, eLetter, shLetter;


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
        letterBox.GetComponent<Image>().sprite = aLetter;
        SoundManager._instance.aSoundPlay();
    }

    public void ClickApple()
    {
        appleGO.SetActive(true);

        appleBool = true;
        if (appleBool && astronautBool )
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = sLetter;
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
            letterBox.GetComponent<Image>().sprite = sLetter;
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
            letterBox.GetComponent<Image>().sprite = tLetter;
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
            letterBox.GetComponent<Image>().sprite = tLetter;
            SoundManager._instance.tSoundPlay();
        }
    }



    public void ClickTeacher()
    {
        teacherGO.SetActive(true);
        teacherBool = true;
        if (teacherBool && turtleBool && telephoneBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = dLetter;
            SoundManager._instance.dSoundPlay();
        }
    }

    public void ClickTurtle()
    {
        turtleGO.SetActive(true);
        turtleBool = true;
        if (turtleBool && teacherBool && telephoneBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = dLetter;
            SoundManager._instance.dSoundPlay();
        }
    }

    public void ClickTelephone()
    {
        telephoneGO.SetActive(true);
        telephoneBool = true;
        if (turtleBool && teacherBool && telephoneBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = dLetter;
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
            letterBox.GetComponent<Image>().sprite = eLetter;
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
            letterBox.GetComponent<Image>().sprite = eLetter;
            SoundManager._instance.eSoundPlay();
        }
    }

    public void ClickElephant()
    {
        elephantGO.SetActive(true);
        elephantBool = true;
        if (elephantBool && eggBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = shLetter;
            SoundManager._instance.shSoundPlay();
        }
    }

    public void ClickEgg()
    {
        eggGO.SetActive(true);
        eggBool = true;
        if (elephantBool && eggBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = shLetter;
            SoundManager._instance.shSoundPlay();
        }
    }

    public void ClickShoe()
    {
        shoesGO.SetActive(true);
        shoeBool = true;
        if (shoeBool && shirtBool && shipBool && sharkBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }

    public void ClickShirt()
    {
        shirtGO.SetActive(true);
        shirtBool = true;
        if (shoeBool && shirtBool && shipBool && sharkBool)
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
        if (shoeBool && shirtBool && shipBool && sharkBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }

    public void ClickShark()
    {
        sharkGO.SetActive(true);
        sharkBool = true;
        if (shoeBool && shirtBool && shipBool && sharkBool)
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
            itemTriggers[i].SetActive(i == currentIndex);
        }
    }

    public void HintsDisplay()
    {
        for (int i = 0; i < hints.Length; i++)
        {
            hints[i].SetActive(i == currentIndex);
            StartCoroutine(HintsHide(i));
        }
    }

    IEnumerator HintsHide(int i)
    {
        yield return new WaitForSeconds(3.0f);
        hints[i].SetActive(false);
    }
}
