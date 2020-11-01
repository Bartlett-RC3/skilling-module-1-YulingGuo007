using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Session_1_Yuling : MonoBehaviour
{
    // 1. variables

    public int myFirstWholeNumber = 1;
    private int mySecondWholeNumber = 99;
    
    public float myFirstDecimalNumber = 1.1234567777777777f;

    public double myFirstLongDecimalNumber = 1.12345677777777771234567777777777d;

    private string myFirstEords = "Hello everyone! Happy to work with you!";

    public string mySecondWord = "Hello!";

    private bool myFirstBoolean = false;
    public bool mySecondBoolean = true;
    // Array
    public int[] myWholeNumbersCollection = new int[5];
    public float[] myDecimalNumbersCollection = { 1.3f, 2.5f, 3.0f };

    //Lists
    public List<int> myFirstIntList = new List<int>();

    // 2. functions
  
    private float CalculatorSum (float _FirstNumber, float _SecondNumber)
    {
        float SumResult = _FirstNumber + _SecondNumber;
        return SumResult;
    }
    // Start is called before the first frame update
    void Start()
    {
        float SumResult = CalculatorSum(myFirstWholeNumber, mySecondWholeNumber);
        System.Diagnostics.Debug.Log("Adding two numbers result is: " + SumResult.ToString());

        myDecimalNumbersCollection[0] = 2.8f;
        float SumRult2 = CalculatorSum(myDecimalNumbersCollection[0], myDecimalNumbersCollection[2]);

        myFirstIntList.Add(3);
        myFirstIntList.Add(9);
        myFirstIntList[0] = 5;
        myFirstIntList[1] = 12;

        System.Diagnostics.Debug.Log(myFirstIntList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
