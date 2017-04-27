using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculatorLogic : MonoBehaviour {
    public InputField field1;
    public InputField field2;
    public float answer;
    public Text showAnswer;
    public int minVal = 1;
    public int maxVal = 150;
    private float fallSpeed = 2.5f;
   
 
    public Button buttonAdd;
    public Button buttonMultiply;
    public Button buttonDivide;
    public Button buttonSubtract;
    public List<Text> RandomNumList = new List<Text>();


    // Use this for initialization
    void Start() {
       
        fallingNum();

    }
        public void Add()
    {
       answer = float.Parse(field1.text) + float.Parse(field2.text);

        showAnswer.text = answer.ToString();

        AnswerDestroyed();

    }

    public void Subtract()
    {
        answer = float.Parse(field1.text) - float.Parse(field2.text);


        showAnswer.text = answer.ToString();

        print(showAnswer.text);

        AnswerDestroyed();


    }
    
    public void Multiply()
    {
        answer = float.Parse(field1.text) * float.Parse(field2.text);

        showAnswer.text = answer.ToString();

        AnswerDestroyed();


    }
    public void Divide()
    {
        answer = float.Parse(field1.text) / float.Parse(field2.text);

        showAnswer.text = answer.ToString();

        AnswerDestroyed();
    }

    public void fallingNum()
    {
        foreach (Text element in RandomNumList)
        {
            int randomNum = (Random.Range(minVal, maxVal));
            element.text = randomNum.ToString();
        }

    }

    private void Update()
    {
       if( buttonAdd.interactable == false && buttonSubtract.interactable == false && buttonMultiply.interactable == false && buttonDivide.interactable == false)
        {
            buttonAdd.interactable = true;
            buttonMultiply.interactable = true;
            buttonDivide.interactable = true;
            buttonSubtract.interactable = true;
        }
    }
    
 
   

    public void numBttn(string numberB)
    {
        
    }

    //disable buttons function
    public void disableAddbttn()
    {
        buttonAdd.interactable = false;
    }

    public void disableSubtractbttn()
    {
        buttonSubtract.interactable = false;
    }

    public void disableMultiplybttn()
    {
        buttonMultiply.interactable = false;
    }

    public void disableDividebttn()
    {
        buttonDivide.interactable = false;
    }
    public void AnswerDestroyed()
    {
        foreach ( Text element in RandomNumList)
        {
            if(showAnswer.text == element.text)
            {
                Destroy(element);
            }
         
        }
    }

 
}
    


    







