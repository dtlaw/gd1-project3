using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ CreateAssetMenu ]
public class TextEvent : ScriptableObject {

	// Types
	[ System.Serializable ]
	public struct TextOption {
		[ SerializeField ]
		private string _shortText;
		public string HashtagText { get { return _shortText; }}
		[ SerializeField ]
		private string _fullText;
		public string FullText { get { return _fullText; }}
		[ SerializeField ]
		private int _score;
		private int Score { get { return _score; }}
	}


	// Exposed variables
	[ SerializeField ]
	private TextOption[] _options = new TextOption[ 3 ];
	public TextOption[] Options { get { return _options; }}
}
