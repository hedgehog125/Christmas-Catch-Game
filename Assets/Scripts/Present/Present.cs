using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Present {
	public class Present : MonoBehaviour {
		[SerializeField] private float m_minY;

		private void FixedUpdate() {
			if (transform.position.y < m_minY) {
				Destroy(gameObject);
				return;
			}
		}
	}
}
