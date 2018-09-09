using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Responsible for keeping a set of things available and allowing a user to widthdraw and deposit them.  Examples of this are resource cards, hex tiles, buildings, etc.
/// </summary>
public abstract class Deck<DataType,ObjectType,Content> : MonoBehaviour where Content : Deck<DataType, ObjectType, Content>.ContentBaseClass
{
	public class ContentBaseClass
	{
		public DataType item;
		public int maxCount;
		[HideInInspector] public int count;
		public bool HasSomethingLeft
		{
			get
			{
				return count > 0;
			}
		}
	}
	
	[SerializeField] protected List<Content> contentDescription;

	/// <summary>
	/// Deck's data structure.
	/// </summary>
	protected Queue<DataType> Data { get; set; }

	/// <summary>
	/// Quantity of each type thing.
	/// </summary>
	protected Dictionary<DataType, Content> Quantities { get; set; }

	/// <summary>
	/// Called by Unity when this object is first created or the game starts.
	/// </summary>
	protected virtual void Awake()
	{
		Data = new Queue<DataType>(contentDescription.Count);
		Quantities = new Dictionary<DataType, Content>(contentDescription.Count);
		foreach(var myContent in contentDescription)
		{
			Quantities[myContent.item] = myContent;
			for(int i=0; i<myContent.maxCount; i++)
			{
				Data.Enqueue(myContent.item); //Todo: Look at copy latter
			}
		}
		Shuffle();
	}
	
	public abstract ObjectType Get();

	public abstract void PutBack(ObjectType item);

	public void Shuffle()
	{
		//TODO: Shuffle Data
	}
}
