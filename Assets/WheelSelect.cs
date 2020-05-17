using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSelect : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject street;
    public GameObject offRoad;
    public GameObject treckter;
    // public GameObject car3opi;

    public int wheelSelected;

    // Start is called before the first frame update
    void Start()
    {
        lowoireng.SetActive(true);
        street.SetActive(false);
        offRoad.SetActive(false);
        treckter.SetActive(false);

        wheelSelected = 1;
    }

    public void loadLowo()
    {
        lowoireng.SetActive(true);
        street.SetActive(false);
        offRoad.SetActive(false);
        treckter.SetActive(false);

        wheelSelected = 1;
    }

    public void loadstreet()
    {
        lowoireng.SetActive(false);
        street.SetActive(true);
        offRoad.SetActive(false);
        treckter.SetActive(false);

        wheelSelected = 1;
    }

    public void loadoffRoad()
    {
        lowoireng.SetActive(false);
        street.SetActive(false);
        offRoad.SetActive(true);
        treckter.SetActive(false);

        wheelSelected = 1;
    }

    public void loadtreckter()
    {
        lowoireng.SetActive(false);
        street.SetActive(false);
        offRoad.SetActive(false);
        treckter.SetActive(true);

        wheelSelected = 1;
    }

    // public void loadCar1yas()
    // {
    //     lowoireng.SetActive(false);
    //     jazz.SetActive(false);
    //     oldracecar.SetActive(false);
    //     sportcar.SetActive(false);
    //     car1yas.SetActive(true);
    //     car2april.SetActive(false);
    //     // car3opi.SetActive(false);

    //     wheelSelected = 1;
    // }

    // public void loadCar2april()
    // {
    //     lowoireng.SetActive(false);
    //     jazz.SetActive(false);
    //     oldracecar.SetActive(false);
    //     sportcar.SetActive(false);
    //     car1yas.SetActive(false);
    //     car2april.SetActive(true);
    //     // car3opi.SetActive(false);

    //     wheelSelected = 1;
    // }

    // // public void loadCar3opi()
    // // {
    // //     lowoireng.SetActive(false);
    // //     jazz.SetActive(false);
    // //     oldracecar.SetActive(false);
    // //     sportcar.SetActive(false);
    // //     car1yas.SetActive(false);
    // //     car2april.SetActive(false);
    // //     // car3opi.SetActive(true);
        
    // //     wheelSelected = 1;
    // // }
}
