using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevReqs : MonoBehaviour
{
    GameObject[] revToggles;

    public void getCompletion()
    {
        int count = 0;
        print(count);

        revToggles = new GameObject[5];

        for (int i = 0; i < 5; i++)
        {
            revToggles[i] = GameObject.Find("chk_rev" + (i + 1));
            if (revToggles[i].GetComponent<Toggle>().isOn)
                count++;
        }

        print(count);

        GameObject slider = GameObject.Find("revSlider");
        Slider s = slider.GetComponent<Slider>();
        s.value = count;

        GameObject txt = GameObject.Find("txt_completeRev");
        Text t = txt.GetComponent<Text>();
        t.text = (count * 20) + "% Complete";

    }
}
