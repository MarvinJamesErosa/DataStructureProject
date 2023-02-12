using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.ExceptionServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectionSort : MonoBehaviour
{

    public GameObject[] pokemon;
    
    int[] pokeIndex = {7, 4, 9, 1};


    public void SelectionSortFunc()
    {
        int index = 0, min = 0, count = pokeIndex.Length;
       

        while (index < count)
        {
            min = index;

            for (int i = index; i < count; i++)
            {
                if (pokeIndex[i] < pokeIndex[min])
                {
                    min = i;
                   
                }
            }

            int temp = pokeIndex[index];
            pokeIndex[index] = pokeIndex[min];
            pokeIndex[min] = temp;

            GameObject temp2 = pokemon[index];
            pokemon[index] = pokemon[min];
            pokemon[min] = temp2;

            Vector2 tempo = pokemon[index].transform.position;

            pokemon[index].transform.position = pokemon[min].transform.position;
            pokemon[min].transform.position = tempo;

            index++;


        }
        foreach (var item in pokeIndex)
        {
            Debug.Log(item);
        }
        foreach (var item in pokemon)
        {
            Debug.Log(item);
        }
    }
}
