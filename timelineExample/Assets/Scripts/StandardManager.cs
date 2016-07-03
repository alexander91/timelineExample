using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class StandardManager : MonoBehaviour {
    private TimeManager timeManager = new TimeManager();

    // Use this for initialization
    void Start () {


        var allBehs = GetComponentsInChildren<MonoBehaviour>();
        var allBehsList = new List<MonoBehaviour>(allBehs);
        var timeDependant = allBehsList.OfType<ITimeChanging>();

        timeManager.TimeDependants = timeDependant;

    }
	
	// Update is called once per frame
	void Update () {
        timeManager.Time += Time.deltaTime;
    }
}
