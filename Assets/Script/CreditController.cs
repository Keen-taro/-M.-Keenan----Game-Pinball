using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditController : MonoBehaviour
{
    public Button creditButton;
    // Start is called before the first frame update
    void Start()
    {
        creditButton.onClick.AddListener(CreditButton);
    }

    public void CreditButton()
    {
        SceneManager.LoadScene(2);
    }
}
