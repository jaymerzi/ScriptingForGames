using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]

public class SimpleTextMeshProBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleFloatData dataObj;

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        UpdateWithIntData();
    }
    public void UpdateWithIntData()
    {
        textObj.text = "x " + dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
    
}