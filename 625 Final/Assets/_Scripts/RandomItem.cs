using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour //Procedural object generation
{
    public List<GameObject> clues;
    public int[] table = { 40, 35, 25 };

    public int total;
    public int randomNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in table)
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);

        for(int i = 0; i < table.Length; i++)
        {
            if(randomNumber <= table[i])
            {
                clues[i].SetActive(true);
                return;
            }
            else
            {
                randomNumber -= table[i];
            }
        }
    }
}
