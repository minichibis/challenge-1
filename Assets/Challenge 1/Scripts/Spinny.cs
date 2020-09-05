/** Sam Carpenter
* Assignment 1
* make plane front bit go vrrrrrrrrrrrrrrrrrrrrrrrrrr
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinny : MonoBehaviour
{
	public float spinspeed;

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(new Vector3(0, 0, 1) * spinspeed * Time.deltaTime);
    }
}
