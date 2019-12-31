using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerSelect : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject steerlain;

    public int steerSelected;

    // Start is called before the first frame update
    void Start()
    {
        lowoireng.SetActive(true);
        steerlain.SetActive(false);

        steerSelected = 1;
    }

    public void loadLowo()
    {
        lowoireng.SetActive(true);
        steerlain.SetActive(false);

        steerSelected = 1;
    }

    public void loadsteerlain()
    {
        lowoireng.SetActive(false);
        steerlain.SetActive(true);

        steerSelected = 1;
    }

}
