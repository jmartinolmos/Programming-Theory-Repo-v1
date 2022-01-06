using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManager2 : MonoBehaviour
{
    public TextMeshProUGUI player;
    // Start is called before the first frame update
    void Start()
    {
        player.text = MainManager.Instance.username;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
