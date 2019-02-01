using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject answerPrefab;
    public Text nameText;
	public Text dialogueText;
	public Animator animator;
    public Queue<Sentences> sentences;
    public Stack<Answers> answers;
    
    void Start() {
        sentences = new Queue<Sentences>();
        answers = new Stack<Answers>();
    }

    	public void StartDialogue (Dialogue dialogue, string title)
	{
	// 	animator.SetBool("IsOpen", true);

		nameText.text = title;

		sentences.Clear();

		foreach (Sentences sentence in dialogue.Sentences)
		{
			sentences.Enqueue(sentence);
		}

        foreach (Answers answer in dialogue.Answers)
        {
            answers.Push(answer);
        }

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
            DisplayAnswers();
			//EndDialogue();
			return;
		}

		Sentences sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

    public void click(GameObject test) 
    {
            test.GetComponentInChildren<Text>().text = "YouClickOnMe";
    }
    public void DisplayAnswers() 
    {
        float offset = 0;
        while (answers.Count != 0) {
            Answers answer = answers.Pop();
            GameObject AnswerPF = Instantiate(answerPrefab);
            
            //set parent (for positionning)
            AnswerPF.transform.SetParent(FindObjectOfType<Canvas>().transform, false);
            //set position
            AnswerPF.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f,0.1f);
            AnswerPF.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f,0.1f);
            AnswerPF.GetComponent<RectTransform>().pivot = new Vector2(0.5f,0.1f);
            AnswerPF.GetComponent<RectTransform>().anchoredPosition = new Vector2(AnswerPF.GetComponent<RectTransform>().anchoredPosition.x, AnswerPF.GetComponent<RectTransform>().anchoredPosition.y + offset);
            
            ///feed content (text, color, ...)///
            AnswerPF.GetComponentInChildren<Text>().text = answer.answer;
            //Text color
            ColorBlock cb = AnswerPF.GetComponent<Button>().colors;
            cb.normalColor = answer.color;
            AnswerPF.GetComponent<Button>().colors = cb;
            //add action
            AnswerPF.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => click(AnswerPF));

            offset += AnswerPF.GetComponentInChildren<Text>().fontSize + 5;
        }
    }

	IEnumerator TypeSentence (Sentences sentence)
	{
		dialogueText.text = "";
        dialogueText.color = sentence.color;
		foreach (char letter in sentence.sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
//		animator.SetBool("IsOpen", false);
	}

}
