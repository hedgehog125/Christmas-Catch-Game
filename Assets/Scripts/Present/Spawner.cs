using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField] private GameObject m_presentPrefab;
	[SerializeField] private float m_xRange;

	[SerializeField] private int m_initialSpawnDelay;
	[SerializeField] private int m_rateIncreaseDelay;
	[SerializeField] private int m_minSpawnDelay;

	private int spawnTick;
	private int spawnDelay;
	private int rateIncreaseTick;

	private void Awake() {
		spawnDelay = m_initialSpawnDelay;
	}

	private void FixedUpdate() {
		if (spawnTick <= 0) {
			spawnTick = spawnDelay;
			SpawnPresent();
		}
		else {
			spawnTick--;
		}

		if (rateIncreaseTick >= m_rateIncreaseDelay) {
			rateIncreaseTick = 0;
			spawnDelay = Mathf.Max(spawnDelay - 1, m_minSpawnDelay);
		}
		else {
			rateIncreaseTick++;
		}
	}

	private void SpawnPresent() {
		float x = Random.Range(-(m_xRange / 2), m_xRange / 2);
		Vector3 spawnPos = new Vector3(x, 0) + transform.position;
		Instantiate(m_presentPrefab, spawnPos, Quaternion.identity);
	}
}
