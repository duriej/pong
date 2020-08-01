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
        switch (state)
        {
            case GameState.START:
                // choose a random point on the centre line for the dot to start at
                // and fire it off either left or right
                float centreY = Random.Range(-475, 475);
                dot.transform.position = new Vector3(0, centreY, 0);

                float angle = Random.Range(-45, 45);
                int direction = (int)Random.Range(0, 1);
                angle = direction == 0 ? angle : 360f - angle;
                dot.Fire(angle);
                state = GameState.PLAY;
                break;
            case GameState.PLAY:
                // check for game over
                break;
            case GameState.PAUSE:
                // wait for game to restart or go back to menu
                break;
            case GameState.GAMEOVER:
                // popup game over dialog
                break;
            case GameState.MENU:
                // wait for player to choose game type and number of players
                break;
        }
    }
}
