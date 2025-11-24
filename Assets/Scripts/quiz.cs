using UnityEngine;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI feedbackText;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private TextMeshProUGUI[] ansTexts;

    private int correctIdx;
    
    private void Start()
    {
        Debug.Log($"Start: correctIdx = {correctIdx}");
    }
    
    
    public void Setup(QuestionInfo info)
    {
        questionText.text = info.QuestionText;
        for (int i = 0; i < ansTexts.Length; i++)
        {
            ansTexts[i].text = info.Answers[i];
        }
        
        correctIdx = info.CorrectAnsIndex;

        feedbackText.text = "Choose what to do";
        feedbackText.color = Color.white;
    }
    
    public void CheckAns(int idx)
    {
        if (idx == correctIdx)
        {
            feedbackText.text = "CORRECT";
            feedbackText.color = Color.green;
        }
        else
        {
            feedbackText.text = "WRONG";
            feedbackText.color = Color.red;
        }
    }

}