using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject jazz;
    public GameObject oldracecar;
    public GameObject sportcar;

    public int carSelected;

    // Start is called before the first frame update
    void Start()
    {
        lowoireng.SetActive(true);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);

        carSelected = 1;
    }

    public void loadLowo()
    {
        lowoireng.SetActive(true);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);

        carSelected = 1;
    }

    public void loadJazz()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(true);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);

        carSelected = 1;
    }

    public void loadOldracecar()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(false);
        oldracecar.SetActive(true);
        sportcar.SetActive(false);

        carSelected = 1;
    }

    public void loadSportcar()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(true);

        carSelected = 1;
    }
}
