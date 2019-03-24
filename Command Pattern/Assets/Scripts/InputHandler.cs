using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	public Transform player;
	private Command kb_W, kb_S, kb_D, kb_A, kb_Space;

	void Start () {
		kb_W = new MoveFoward();
		kb_S = new MoveBackward();
		kb_D = new MoveRight();
		kb_A = new MoveLeft();
		kb_Space = new Jump();
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			kb_W.Execute(player.transform);
		}
		if (Input.GetKey(KeyCode.S))
		{
			kb_S.Execute(player.transform);
		}
		if (Input.GetKey(KeyCode.A))
		{
			kb_A.Execute(player.transform);
		}
		if (Input.GetKey(KeyCode.D))
		{
			kb_D.Execute(player.transform);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			kb_Space.Execute(player.transform);
		}
	}
}
