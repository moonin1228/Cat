using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeCSV : MonoBehaviour
{
    List<List<int>> data_01 = CSVReader.Read("111");

    private void Start()
    {
        for(int i = 0; i < data_01.Count; i++)
        {
            print(data_01[i][0].ToString());
        }
    }
}
