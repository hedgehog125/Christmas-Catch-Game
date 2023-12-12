using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
	public class Movement : MonoBehaviour {
		[SerializeField] private float m_moveSpeed;

		private Vector2 moveInput;
		private void OnMove(InputValue input) {
			moveInput = input.Get<Vector2>();
		}

		private Rigidbody2D rb;
		private void Awake() {
			rb = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate() {
			Vector2 vel = rb.velocity;

			vel.x = moveInput.x * m_moveSpeed;

			rb.velocity = vel;
		}
	}
}
