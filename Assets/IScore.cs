﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScore
{
	Player myPlayer { get; }
	float VictoryPoints { get; }
}
