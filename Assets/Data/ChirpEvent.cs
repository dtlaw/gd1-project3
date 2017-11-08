using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ CreateAssetMenu ]
public class ChirpEvent : ScriptableObject {

	// Types
	[ System.Serializable ]
	public struct ChirpOption {
		[ SerializeField ]
		private string _hashtagText;
		public string HashtagText { get { return _hashtagText; }}
		[ SerializeField ]
		private string _fullText;
		public string FullText { get { return _fullText; }}
		[ SerializeField ]
		private int _score;
		private int Score { get { return _score; }}
	}


	// Exposed variables
	[ SerializeField ]
	private ChirpOption[] _options = new ChirpOption[ 3 ];
	public ChirpOption[] Options { get { return _options; }}
}
