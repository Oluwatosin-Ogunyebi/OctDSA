using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{   
    static int numberOfIterations = 0;
    public int[] arrayInitial = new int[10];
    public int[] array = new int[10];
    public string[] names = new string[10];
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {   
            int randomNum = Random.Range(0, 100);
            array[i] = randomNum;
            arrayInitial[i] = randomNum;
        }
        PerformBubleSort(array);

        string solutionToArray = "";
        for (int i = 0; i < array.Length; i++)
        {
            solutionToArray += array[i] + " , ";
        }

        Debug.Log(solutionToArray);


        for (int i = 0; i < arrayInitial.Length; i++)
        {
            dictionary.Add(names[i], arrayInitial[i]);
            Debug.Log($"Name is {names[i]} and score is {dictionary[names[i]]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PerformBubleSort(int[] arrayToSort)
    {
        bool swapped;

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            swapped = false;
            for (int j = 0; j < arrayToSort.Length-i -1; j++)
            {
                if (arrayToSort[j] > arrayToSort[j+1])
                {
                    int tempValue = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[j+1];
                    arrayToSort[j+1] = tempValue;
                    swapped = true;
                }
                numberOfIterations++;
                Debug.Log("Number of iterations: " + numberOfIterations);
            }
            //If no two elemtns were swapped in the inner loop, the array is sorted
            if (!swapped)
            {
                break;
            }
        }
    }
}
