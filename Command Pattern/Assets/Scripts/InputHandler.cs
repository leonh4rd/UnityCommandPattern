using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour 
{
	private bool waitingChangeKey = false;
	public Transform player;
	private Command moveforward, movebackward, moveright, moveleft, jump;
	private KeyCode forwardkey, backwardkey, leftkey, rightkey, jumpkey;
	private bool lockMovement = false;
	public Button MoveForwardButton;
	public Button MoveBackwardButton;
	public Button MoveLeftButton;
	public Button MoveRightButton;
	public Button JumpButton;

	void Start () {
		moveforward = new MoveFoward();
		movebackward = new MoveBackward();
		moveright = new MoveRight();
		moveleft = new MoveLeft();
		jump = new Jump();
		forwardkey = KeyCode.W;
		backwardkey = KeyCode.S;
		leftkey = KeyCode.A;
		rightkey = KeyCode.D;
		jumpkey = KeyCode.Space;
	}
	
	void Update () {
		if(waitingChangeKey)
		{
			if(Input.anyKeyDown)
			{
				foreach(KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
				{
					if(Input.GetKeyDown(key))
					{
						jumpkey = key;
						waitingChangeKey = false;
						SetupKeyConfiguration();
						break;					}
				}
			}
		}
		else
		{
			if(Input.GetKeyDown(KeyCode.Escape))
			{
				if(GameManager.Pause)
				{
					GameManager.Pause = false;
					lockMovement = false;
					GameManager.PauseMenu.SetActive(false);
				}else
				{
					SetupKeyConfiguration();
					GameManager.Pause = true;
					lockMovement = true;
					GameManager.PauseMenu.SetActive(true);
				}
			}

			if(!lockMovement)
			{
				if (Input.GetKey(KeyCode.W))
				{
					moveforward.Execute(player.transform);
				}
				if (Input.GetKey(KeyCode.S))
				{
					movebackward.Execute(player.transform);
				}
				if (Input.GetKey(KeyCode.A))
				{
					moveleft.Execute(player.transform);
				}
				if (Input.GetKey(KeyCode.D))
				{
					moveright.Execute(player.transform);
				}
				if (Input.GetKeyDown(jumpkey))
				{
					jump.Execute(player.transform);
				}
			}
		}
	}

	private void SetupKeyConfiguration()
	{
		MoveForwardButton.GetComponentInChildren<Text>().text = forwardkey.ToString();
		MoveBackwardButton.GetComponentInChildren<Text>().text = backwardkey.ToString();
		MoveLeftButton.GetComponentInChildren<Text>().text = leftkey.ToString();
		MoveRightButton.GetComponentInChildren<Text>().text = rightkey.ToString();
		JumpButton.GetComponentInChildren<Text>().text = jumpkey.ToString();
	}

	public void JumpButtonChange()
	{
		JumpButton.gameObject.GetComponentInChildren<Text>().text = "Press any key";
		waitingChangeKey = true;
	}
}
