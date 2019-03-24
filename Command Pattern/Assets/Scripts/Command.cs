using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command{

	protected float speed = 0.3f;

	public abstract void Execute(Transform transform); 

}

public class MoveFoward : Command 
{
	public override void Execute(Transform transform)
	{
		transform.Translate(transform.forward * speed);
	}
}

public class MoveBackward : Command
{
	public override void Execute(Transform transform)
	{
		transform.Translate(transform.forward * -speed);
	}
}

public class MoveRight : Command
{
	public override void Execute(Transform transform)
	{
		transform.Translate(transform.right * speed);
	}
}

public class MoveLeft : Command
{
	public override void Execute(Transform transform)
	{
		transform.Translate(transform.right * -speed);
	}
}

public class Jump : Command
{
	public override void Execute(Transform transform)
	{
		transform.GetComponent<Rigidbody>().AddForce(transform.up*6f, ForceMode.Impulse);
	}
}

public class ShootWeapon : Command
{
	public override void Execute(Transform transform)
	{
		
	}
}
