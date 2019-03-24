using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command{

	public abstract void Execute(GameObject gameObject); 

}

public class MoveFoward : Command 
{
	public override void Execute(GameObject gameObject)
	{
		gameObject.transform.Translate(gameObject.transform.forward);
	}
}