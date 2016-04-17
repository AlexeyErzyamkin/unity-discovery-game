using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	private Engine _engine;
    private RotateEngine _rotateEngine;

	void Start()
	{
		_engine = gameObject.GetComponent<Engine>();
		DebugUtils.Assert(_engine != null, "The Engine component is null!");

        _rotateEngine = gameObject.GetComponent<RotateEngine>();
        DebugUtils.Assert(_rotateEngine != null, "The RotateEngine component is null!");
	}
	
	void Update()
	{
        if (_engine == null || _rotateEngine == null) {
            return;
        }

        if (Input.GetKey(KeyCode.Space)) {
            _engine.Throttle = 1f;
        }
        else {
            _engine.Throttle = 0f;
        }

        //if (Input.GetKey(KeyCode.LeftArrow)) {
        //    _rotateEngine.Throttle = -1f;
        //}
        //else
        //if (Input.GetKey(KeyCode.RightArrow)) {
        //    _rotateEngine.Throttle = 1f;
        //}
        //else {
        //    _rotateEngine.Throttle = 0f;
        //}

        _rotateEngine.Throttle = Input.GetAxis("Horizontal");
	}
}
