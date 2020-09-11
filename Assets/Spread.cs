using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spread : MonoBehaviour
{
    public GameObject sub;
    public RectTransform root;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            sub.SetActive(!sub.activeSelf);
            LayoutRebuilder.ForceRebuildLayoutImmediate(root);
        });
    }
}
