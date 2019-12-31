using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSelect : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject coklat;
    public GameObject race;

    public int chairSelected;

    // Start is called before the first frame update
    void Start()
    {
        lowoireng.SetActive(true);
        coklat.SetActive(false);
        race.SetActive(false);

        chairSelected = 1;
    }

    public void loadLowo()
    {
        lowoireng.SetActive(true);
        coklat.SetActive(false);
        race.SetActive(false);

        chairSelected = 1;
    }

    public void loadcoklat()
    {
        lowoireng.SetActive(false);
        coklat.SetActive(true);
        race.SetActive(false);

        chairSelected = 1;
    }

    public void loadrace()
    {
        lowoireng.SetActive(false);
        coklat.SetActive(false);
        race.SetActive(true);


        chairSelected = 1;
    }

}
