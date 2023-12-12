using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
	public class Player : MonoBehaviour {
		private void OnTriggerEnter2D(Collider2D collision) {
			if (collision.gameObject.CompareTag("Present")) {
				Destroy(collision.gameObject);
			}
		}
	}
}
