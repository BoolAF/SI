﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour {

    public float health = 2;

	void Start () {
		
	}
	
	void Update () {
        if (health <= 0)
            Destroy(gameObject);
	}
}
