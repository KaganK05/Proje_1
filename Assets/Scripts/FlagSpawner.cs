using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagSpawner : MonoBehaviour
{

    public Sprite[] flags;

    public Image flag;
    public Image flag2;
    public Image flag3;
    public Image flag4;

    private Text FlagQuestion;
    private int trueAnswer;


    private void Start()
    {
        ChangeImage();

        FlagQuestion = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            int num = UnityEngine.Random.Range(0, flags.Length);
            flag.sprite = flags[num];
            int num2 = UnityEngine.Random.Range(0, flags.Length);
            flag2.sprite = flags[num2];
            int num3 = UnityEngine.Random.Range(0, flags.Length);
            flag3.sprite = flags[num3];
            int num4 = UnityEngine.Random.Range(0, flags.Length);
            flag4.sprite = flags[num4];
        }
    }
    void ChangeImage()
    {
        int num = UnityEngine.Random.Range(0, flags.Length);
        flag.sprite = flags[num];
        int num2 = UnityEngine.Random.Range(0, flags.Length);
        flag2.sprite = flags[num2];
        int num3 = UnityEngine.Random.Range(0, flags.Length);
        flag3.sprite = flags[num3];
        int num4 = UnityEngine.Random.Range(0, flags.Length);
        flag4.sprite = flags[num4];
    }
}
