using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExtrabuttonController : MonoBehaviour
{
    
[SerializeField]
Button btnControles, btnCerrarControles;
[SerializeField]
GameObject UIControles, UICreditos;

[SerializeField]
Button btnCreditos, btnCerrarCreditos;
    // Start is called before the first frame update
    void Start()
    {
        this.btnControles.onClick.AddListener(() => OnControlesClicked());
        this.btnCerrarControles.onClick.AddListener(() => OnControlesOffClicked());
        this.btnCreditos.onClick.AddListener(() => OnCreditosClicked());
        this.btnCerrarCreditos.onClick.AddListener(() => OnCreditosOffClicked());

        UIControles.SetActive(false);
        UICreditos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControlesClicked()
    {
         UIControles.SetActive(true);
    }
    void OnControlesOffClicked()
    {
        UIControles.SetActive(false);
    }
    void OnCreditosClicked()
    {
        UICreditos.SetActive(true);
    }
    void OnCreditosOffClicked()
    {
    UICreditos.SetActive(false);

    }
}
