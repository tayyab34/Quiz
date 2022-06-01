using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Subject",menuName ="Subjects")]
public class Quiz : ScriptableObject
{
    public string question;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
}
