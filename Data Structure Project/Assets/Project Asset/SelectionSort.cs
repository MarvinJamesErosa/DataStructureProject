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
    // This array stores the pokemon game object
    public GameObject[] pokemon;

    // This array is paralleled with the pokemon array, it acts as an index as to be able to sort the items
    int[] pokeIndex = {007, 004, 025, 001, 052, 104, 63, 143, 129, 133};

    // This is the Selection Sort Function
    public void SelectionSortFunc()
    {
        int index = 0, min = 0, count = pokeIndex.Length;
       
        // This fuction is to find the index of the smallest integer in the pokeIndex array
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
        
        // This is the swap function to sort the pokeIndex array
            int temp = pokeIndex[index];
            pokeIndex[index] = pokeIndex[min];
            pokeIndex[min] = temp;
        
        // This is the swap function to sort the pokemon array
            GameObject temp2 = pokemon[index];
            pokemon[index] = pokemon[min];
            pokemon[min] = temp2;
        
        // This is the function that swap the GameObject position 
            Vector2 temp3 = pokemon[index].transform.position;

            pokemon[index].transform.position = pokemon[min].transform.position;
            pokemon[min].transform.position = temp3;

        // This is to increment the index as to create the sorted area of the array 
            index++;
        }
        
        // For debugging purposes
        foreach (var item in pokeIndex)
        {
            Debug.Log(item);
        }

        foreach (var item in pokemon)
        {
            Debug.Log(item);
        }
    }

    public void RandomizeFunc()
    {
        foreach (var item in pokeIndex)
        {
            System.Random rand = new System.Random();
            int pokemon1 = rand.Next(0, pokeIndex.Length);

            int pokemon2 = rand.Next(0, pokeIndex.Length);

            // This is the swap function to sort the pokeIndex array
            int temp = pokeIndex[pokemon1];
            pokeIndex[pokemon1] = pokeIndex[pokemon2];
            pokeIndex[pokemon2] = temp;

            // This is the swap function to sort the pokemon array
            GameObject temp1 = pokemon[pokemon1];
            pokemon[pokemon1] = pokemon[pokemon2];
            pokemon[pokemon2] = temp1;

            // This is the function that swap the GameObject position 
            Vector2 temp2 = pokemon[pokemon1].transform.position;

            pokemon[pokemon1].transform.position = pokemon[pokemon2].transform.position;
            pokemon[pokemon2].transform.position = temp2;
        } 
    }

    public void QuitFunc()
    {
        Application.Quit();
    }
}
