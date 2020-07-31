using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GameState state;
	public Player playerLeftOuter;
	public Player playerRightOuter;
	public Player playerLeftInner;
	public Player playerRightInner;

	public Dot dot;

    void Start()
    {
        state = GameState.MENU;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
