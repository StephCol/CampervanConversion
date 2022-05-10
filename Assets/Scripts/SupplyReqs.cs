using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public class SupplyReqs : MonoBehaviour
{
    internal class SQIEntry
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }
    }

    void Start()
    {
        GameObject txt = GameObject.Find("txt_supplies");
        Text t = txt.GetComponent<Text>();

        var webRequest = WebRequest.Create("https://sheet.best/api/sheets/263aa7cb-4815-4e0c-8216-9503847bf94b") as HttpWebRequest;
        if (webRequest == null)
        {
            return;
        }

        webRequest.ContentType = "application/json";
        webRequest.UserAgent = "Nothing";
        var s = webRequest.GetResponse().GetResponseStream();
        var sr = new StreamReader(s);
        var entriesAsJson = sr.ReadToEnd();
        var entries = JsonConvert.DeserializeObject<List<SQIEntry>>(entriesAsJson);
        entries.ForEach(Console.WriteLine);

        Console.ReadLine();
        t.text = "";

        for (var i = 0; i < entries.Count; i++)
        {
            t.text += "Company: " + entries[i].Name + "\nContact: " + entries[i].Number + "\nLocation: " + entries[i].Location + "\n\n";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}



