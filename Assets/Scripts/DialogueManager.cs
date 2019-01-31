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
    void Start() {
        sentences = new Queue<Sentences>();
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

        public void click(GameObject test) {
            test.GetComponentInChildren<Text>().text = "Click";
            Debug.Log("click");
        }
    public void DisplayAnswers() 
    {
            GameObject AnswerPF = Instantiate(answerPrefab);
            AnswerPF.transform.SetParent(FindObjectOfType<Canvas>().transform, false);
            AnswerPF.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f,0.1f);
            AnswerPF.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f,0.1f);
            AnswerPF.GetComponent<RectTransform>().pivot = new Vector2(0.5f,0.1f);
            AnswerPF.GetComponentInChildren<Text>().text = "test";
            AnswerPF.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => click(AnswerPF));
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
