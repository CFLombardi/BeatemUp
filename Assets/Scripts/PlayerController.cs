using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
		public int health;
    // Start is called before the first frame update
    void Start()
    {
				health = 10;
        print("Hello!");
    }

    // Update is called once per frame
    void Update()
    {

    }

		public int getHealth()
		{
			return health;
		}

}
