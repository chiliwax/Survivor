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
    public GameObject Continue_button;
    private bool inDiscuss = false;
    
    void Start() {
        sentences = new Queue<Sentences>();
        answers = new Stack<Answers>();
        animator.SetBool("IsDialogue", false);
        Continue_button.SetActive(true);
    }

    	public void StartDialogue (Dialogue dialogue, string title)
	{
        animator.SetBool("IsDialogue", true);
        if (inDiscuss == true) {return;}
        inDiscuss = true;
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
        if (sentences.Count > 0)
		{
            Continue_button.SetActive(true);
            Sentences sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }
		if (sentences.Count == 0 && answers.Count > 0)
		{
            Continue_button.SetActive(false);
            DisplayAnswers();
		}
	}

    public void click(GameObject test, List<GameObject> listing, Answers answer) 
    {
            EndDialogue();
            test.GetComponentInChildren<Text>().text = "YouClickOnMe";
            if (answer.action != null) {
                if(answer.action.GetComponent<mainmenu>())
                    answer.action.GetComponent<mainmenu>().Mainmenu();
                if(answer.action.GetComponent<DialogueTrigger>())
                    answer.action.GetComponent<DialogueTrigger>().TriggerDialogue();
            }
            foreach (GameObject answers in listing) {
            Destroy(answers);
            }
    }
    public void DisplayAnswers() 
    {
        List<GameObject> listing = new List <GameObject>();
        float offset = 0;
        while (answers.Count != 0) {
            Answers answer = answers.Pop();
            //create button
            GameObject AnswerPF = Instantiate(answerPrefab);
            //save data to destroy instantiate prefab after
            listing.Add(AnswerPF);
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
            cb.highlightedColor = new Color(answer.color.r - 0.7f, answer.color.g - 0.7f, answer.color.b - 0.7f);
            cb.pressedColor = new Color(answer.color.r - 0.6f, answer.color.g - 0.6f, answer.color.b - 0.6f);
            AnswerPF.GetComponent<Button>().colors = cb;
            //add action
            AnswerPF.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => click(AnswerPF, listing, answer));
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
        inDiscuss = false;
//		animator.SetBool("IsOpen", false);
        animator.SetBool("IsDialogue", false);
	}

        private IEnumerator WaitForAnimation ( Animation animation )
    {
        do
        {
            yield return null;
        } while ( animation.isPlaying );
    }
}
