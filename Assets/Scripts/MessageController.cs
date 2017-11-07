using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour {

	// Exposed variables
	[ SerializeField ]
	private Button[] _selectionButtons = new Button[ 3 ];
	[ SerializeField ]
	private Transform _messageThread;
	[ SerializeField ]
	private ChirpEvent[] _events;
	[ SerializeField ]
	private GameObject _messagePrefab;


	// Private variables
	private ChirpEvent _currentEvent;


	// Messages
	private void Start() {
		LoadEvent( _events[ 0 ]);
	}



	// Public interface
	public void TriggerEvent( int index ) {
		LoadEvent( _events[ index ]);
	}

	// TODO: Code for adding a message when a button is clicked
	public void SelectMessage( int index ) {
		GameObject m = Instantiate( _messagePrefab, _messageThread );
		m.GetComponentInChildren< Text >().text = _currentEvent.Options[ index ].FullText;
		m.GetComponent< Transform >().SetSiblingIndex( 0 );

		// TODO: Lerp-scroll to top when new message is added?
	}


	// Private interface
	private void LoadEvent( ChirpEvent e ) {
		for ( int i = 0; i < _selectionButtons.Length; ++i ) {
			_currentEvent = e;
			_selectionButtons[ i ].GetComponentInChildren< Text >().text = e.Options[ i ].HashtagText;
		}
	}
}
