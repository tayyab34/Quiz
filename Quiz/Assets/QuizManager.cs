using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public Dropdown menu;
    public TextMeshProUGUI question;
    public Quiz[] quiz;
    public GameObject options;
    public TextMeshProUGUI optionA;
    public TextMeshProUGUI optionB;
    public TextMeshProUGUI optionC;
    public TextMeshProUGUI optionD;
    public TextMeshProUGUI message;
    public Button option1;
    public Button option2;
    public Button option3;
    public Button option4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Listener();
        Display();
    }
    private void Listener()
    {
        if (menu.options[menu.value].text == "English")
        {
            option1.onClick.AddListener(() => { message.text = "Answer Correct"; });
            option2.onClick.AddListener(() => { message.text = "Answer Wrong"; });
            option3.onClick.AddListener(() => { message.text = "Answer Wrong"; });
            option4.onClick.AddListener(() => { message.text = "Answer Wrong"; });
        }
        if (menu.options[menu.value].text == "Math")
        {
            option4.onClick.AddListener(() => { message.text = "Answer Correct"; });
            option2.onClick.AddListener(() => { message.text = "Answer Wrong"; });
            option3.onClick.AddListener(() => { message.text = "Answer Wrong"; });
            option1.onClick.AddListener(() => { message.text = "Answer Wrong"; });
        }
        if (menu.options[menu.value].text == "Science")
        {
            option2.onClick.AddListener(() => { message.text = "Answer Correct"; });
            option4.onClick.AddListener(() => { message.text = "Answer Wrong"; });
            option3.onClick.AddListener(() => { message.text = "Answer Wrong"; });
            option1.onClick.AddListener(() => { message.text = "Answer Wrong"; });
        }
        if (message.isActiveAndEnabled)
        {
            StartCoroutine(InactiveMessageUI());
        }
    }
    private void Display()
    {
        if (menu.options[menu.value].text == "English")
        {
            options.SetActive(true);
            question.text = quiz[0].question;
            optionA.text = quiz[0].optionA;
            optionB.text = quiz[0].optionB;
            optionC.text = quiz[0].optionC;
            optionD.text = quiz[0].optionD;
        }
        if (menu.options[menu.value].text == "Math")
        {
            options.SetActive(true);
            question.text = quiz[1].question;
            optionA.text = quiz[1].optionA;
            optionB.text = quiz[1].optionB;
            optionC.text = quiz[1].optionC;
            optionD.text = quiz[1].optionD;
        }
        if (menu.options[menu.value].text == "Science")
        {
            options.SetActive(true);
            question.text = quiz[2].question;
            optionA.text = quiz[2].optionA;
            optionB.text = quiz[2].optionB;
            optionC.text = quiz[2].optionC;
            optionD.text = quiz[2].optionD;
        }
    }
    IEnumerator InactiveMessageUI()
    {
        yield return new WaitForSeconds(0.5f);
        message.gameObject.SetActive(false);
        message.gameObject.SetActive(false);
       
    }
}
