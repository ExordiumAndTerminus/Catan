using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base factory interface
/// </summary>
public interface IFactory { }

/// <summary>
/// Generic factory interface
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFactory<T> : IFactory
{
	T Generate();
}
