using UnityEngine;
using System.Collections;

public class SceneInit : MonoBehaviour
{
    public GameObject cloud;

	void Start()
    {
        for (int i = 0; i < 200; ++i) {
            var cloudPosition = new Vector3((Random.value * 200) - 100, 80 + (Random.value * (i * (i/2))), (Random.value * 80) - 12);
            var eachCloud = Instantiate(
                cloud,
                cloudPosition,
                Quaternion.identity) as GameObject;

            eachCloud.transform.localScale = (new Vector3(1, 1, 1)) * 15;
        }
	}
}
