using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceCardFactory : MonoBehaviour 
{
	[System.Serializable]
	protected struct Item
	{
		public ResourceTypes Type;
		public GameObject prefab;
	}
	[SerializeField] List<Item> prefabs;

	public static ResourceCardFactory Singleton { get; private set; }

	protected Dictionary<ResourceTypes, GameObject> prefabByType;

	private void Awake()
	{
		prefabByType = prefabs.ToDictionary(k => k.Type, v => v.prefab);
		if(Singleton != null) throw new System.Exception("You have multiple ResourceCardFactory's, so, I'm going to die.");
		Singleton = this;
	}

	public ResourceCard Generate(ResourceTypes type)
	{
		return GameObject.Instantiate(prefabByType[type]).GetComponent<ResourceCard>();
	}
}
