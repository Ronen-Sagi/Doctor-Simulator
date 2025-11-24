using System.Collections;
using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI feedbackText;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private GameObject nextQuiz;


    private void Start()
    {
    }


    public void Setup(QuestionInfo info)
    {
        questionText.text = info.QuestionText;
        feedbackText.text = "Choose what to do";
        feedbackText.color = Color.white;
    }

    public void CheckAns(bool isCorrect)
    {
        if (isCorrect)
        {
            feedbackText.text = "CORRECT";
            feedbackText.color = Color.green;
            StartCoroutine(NextQuestionAfterDelay());
        }
        else
        {
            feedbackText.text = "WRONG";
            feedbackText.color = Color.red;
            StartCoroutine(NextQuestionAfterDelay());
        }
    }

    private void NextQuiz()
    {
        StartCoroutine(NextQuestionAfterDelay());
        nextQuiz.SetActive(true);
        gameObject.SetActive(false);
    }

    IEnumerator NextQuestionAfterDelay()
    {
        yield return new WaitForSeconds(3);
        NextQuiz();
    }
}