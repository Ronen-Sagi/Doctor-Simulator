using Unity.VisualScripting;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private Quiz quizPanel;  
    [SerializeField] private QuestionInfo[] questions;

    private int currIdx = 0;

    void Start()
    {
        ShowQues(0);
    }

    private void ShowQues(int idx)
    {
        currIdx = idx;
        quizPanel.Setup(questions[currIdx]);
    }

    public void NextQues()
    {
        currIdx++;
        if (currIdx >= questions.Length)
        {
            Debug.Log("Quiz finished!"); // change to end screen later
        }
        else
        {
            ShowQues(currIdx);
        }
    }
}

