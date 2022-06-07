using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Iterator : MonoBehaviour
{
    public int currentValue = 0;
    public GameObject scoreRendererObject;
    private TextMeshProUGUI textRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.textRenderer = scoreRendererObject.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        this.textRenderer.text = currentValue.ToString();
    }

    void Increment(int value)
    {
        currentValue += value;
    }
}
