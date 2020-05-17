using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject jazz;
    public GameObject oldracecar;
    public GameObject sportcar;
    public GameObject car1yas;
    public GameObject car2april;
    // public GameObject car3opi;

    public int carSelected;

    // Start is called before the first frame update
    void Start()
    {
        lowoireng.SetActive(true);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);
        car1yas.SetActive(false);
        car2april.SetActive(false);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    public void loadLowo()
    {
        lowoireng.SetActive(true);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);
        car1yas.SetActive(false);
        car2april.SetActive(false);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    public void loadJazz()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(true);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);
        car1yas.SetActive(false);
        car2april.SetActive(false);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    public void loadOldracecar()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(false);
        oldracecar.SetActive(true);
        sportcar.SetActive(false);
        car1yas.SetActive(false);
        car2april.SetActive(false);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    public void loadSportcar()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(true);
        car1yas.SetActive(false);
        car2april.SetActive(false);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    public void loadCar1yas()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);
        car1yas.SetActive(true);
        car2april.SetActive(false);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    public void loadCar2april()
    {
        lowoireng.SetActive(false);
        jazz.SetActive(false);
        oldracecar.SetActive(false);
        sportcar.SetActive(false);
        car1yas.SetActive(false);
        car2april.SetActive(true);
        // car3opi.SetActive(false);

        carSelected = 1;
    }

    // public void loadCar3opi()
    // {
    //     lowoireng.SetActive(false);
    //     jazz.SetActive(false);
    //     oldracecar.SetActive(false);
    //     sportcar.SetActive(false);
    //     car1yas.SetActive(false);
    //     car2april.SetActive(false);
    //     // car3opi.SetActive(true);
        
    //     carSelected = 1;
    // }
}
