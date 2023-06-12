using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Director : MonoBehaviour
{
    private List<Bus> inimigos = new List<Bus>();
    private PlayerControl player1;
    private PlayerControl2 player2;
    [SerializeField]
    public GameObject gameTitle;
    [SerializeField]
    public GameObject gameUserIterface;
    private bool gamePause;
    private TextMeshProUGUI textWin;
 

    // Start is called before the first frame update
    void Start()
    {
        foreach(var bus in GameObject.FindObjectsOfType<Bus>())
        {
            inimigos.Add(bus);
        }

        player1 = GameObject.FindObjectOfType<PlayerControl>();

        player2 = GameObject.FindObjectOfType<PlayerControl2>();

        foreach (var text in GameObject.FindObjectsOfType<TextMeshProUGUI>())
        {
            if(text.name == "PlayerWin")
            {
                textWin = text;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameTitle.SetActive(false);

            gameUserIterface.SetActive(true);

            foreach (var bus in inimigos)
            {
                bus.SetStartEnemies(true);
            }

            player1.SetStartPlayer(true);

            player2.SetStartPlayer(true);
 
        }

        if(player1.detectFinal())
        {
            foreach (var bus in inimigos)
            {
                bus.SetStartEnemies(false);
            }

            player1.SetStartPlayer(false);

            player2.SetStartPlayer(false);

            textWin.enabled = true;

            textWin.text = "Player 1 Win!";
        }

        if (player2.detectFinal())
        {
            foreach (var bus in inimigos)
            {
                bus.SetStartEnemies(false);
            }

            player1.SetStartPlayer(false);

            player2.SetStartPlayer(false);
        }
    }
}
