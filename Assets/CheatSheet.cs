using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatSheet : MonoBehaviour 
{
	#region Actions
	Action<int> action1;
	Action<int,int> action2;
	Func<int> func1;
	#endregion

	#region Methods
	void Method0(int param1)
	{
		Debug.Log(param1);
	}
	void Method1(int param1)
	{
		Debug.Log(param1);
	}
	void Method2(int param1, int param2)
	{
		Debug.Log(param1 + " " + param2);
	}

	int Method3()
	{
		return 1;
	}
	#endregion
	private void Start()
	{
		action1 = Method1;
		action1 += Method0;
		action1(5); //Calls Method1 & Method0


		//Add a lamda expression:
		action1 += (int param1) =>
		{
			//do something
		};

		//All equivelent:
		action1 += (param1) =>
		{
			Debug.Log(param1);
		};

		action1 += param1 =>
		{
			Debug.Log(param1);
		};

		action1 += param1 => Debug.Log(param1);








		action2 = (int param1, int param2) =>
		{
			Debug.Log(param1 + " " + param2);
		};

		action2 = (param1, param2) =>
		{
			Debug.Log(param1 + " " + param2);
		};

		action2 = (param1, param2) => Debug.Log(param1 + " " + param2);













		func1 = Method3;

		//or:

		func1 = () =>
		{
			return 1;
		};

		func1 = () => 1;








		//Linq Example:
		/*
		
		// take from contents all content(s) that have something left:
		var something = contents.Where(c => c.HasSomethingLeft);


		//Same thing:
		List<Content> something2 = new List<Content>(contents.Count);
		foreach(var c in contents)
		{
			if(c.HasSomethingLeft) something2.Add(c);
		}

		*/







		//How "Where" works on IEnumerable

		/*
		horse.Where(c=>true);

		private IEnumerable<T> Where<T>(this IEnumerable<T> horse, System.Func<T, bool> condition)
		{
			foreach(var val in enumerable)
			{
				if(condition(val)) yield return val;
			}
		}
		*/
	}
}
