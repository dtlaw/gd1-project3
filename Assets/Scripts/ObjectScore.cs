using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScore : MonoBehaviour {

	// Exposed variables
	[ SerializeField ]
	private float _score;
	public float Score { get { return _score; }}
}
