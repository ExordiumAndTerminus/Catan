using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour 
{
	public ResourceCardDeck deck;

	Queue<ResourceCard> cards = new Queue<ResourceCard>();

	public void Get()
	{
		var item = deck.Get();
		if(item!=null) cards.Enqueue(item);
	}

	public void PutBack()
	{
		if(cards.Count==0) return;

		deck.PutBack(cards.Dequeue());
	}
}
