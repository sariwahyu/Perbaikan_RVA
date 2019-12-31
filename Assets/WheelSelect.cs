using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSelect : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject street;
    public GameObject offRoad;
    public GameObject treckter;

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
}
