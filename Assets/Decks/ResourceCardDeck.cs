using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCardDeck : Deck<ResourceType, ResourceCard, ResourceCardDeck.MyContent> 
{
	[System.Serializable]
	public class MyContent : ContentBaseClass
	{
		public ResourceType type;
	}

	protected override void Awake()
	{
		foreach(var c in contentDescription)
		{
			c.item = c.type;
		}
		base.Awake();
	}

	public override ResourceCard Get()
	{
		if(Data.Count == 0) return null;

		var cardType = Data.Dequeue();
		if(cardType != null && cardType.HasValue)
		{
			Quantities[cardType.Value].count--;
		}
		else return null;
		return ResourceCardFactory.Singleton.Generate(cardType.Value); /////TODO Figure out a good factory interface here
	}

	public override void PutBack(ResourceCard item)
	{
		Data.Enqueue(item.Type);
		Quantities[item.Type].count++;
		Object.Destroy(item.gameObject );
	}
}
