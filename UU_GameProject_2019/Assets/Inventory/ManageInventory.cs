﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageInventory : MonoBehaviour
{
    public GameObject Item1, Item2, Item3, Item4;
    public GameObject Cursor;
    public int Selection { get; private set; }

    void Start()
    {
        SwitchItem(Selection);
    }

    void Update()
    {
        if (Input.GetKeyDown("e")) SwitchItem(Selection + 1);
        if (Input.GetKeyDown("q")) SwitchItem(Selection - 1);
        if (Input.GetKeyDown("1")) SwitchItem(0);
        if (Input.GetKeyDown("2")) SwitchItem(1);
        if (Input.GetKeyDown("3")) SwitchItem(2);
        if (Input.GetKeyDown("4")) SwitchItem(3);
    }

    public void SwitchItem(int switchto)
    {
        if (switchto >= 0 && switchto <= 3)
        {
            Selection = switchto;
            GameObject[] ItemList = new GameObject[] { Item1, Item2, Item3, Item4 };
            foreach (GameObject o in ItemList)
            {
                o.SetActive(false);
            }
            ItemList[Selection].SetActive(true);
            Cursor.transform.localPosition = new Vector3(0, 150 - 100*Selection, 0);
        }
    }
}
