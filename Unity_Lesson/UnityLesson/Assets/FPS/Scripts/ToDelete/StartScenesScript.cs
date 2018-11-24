using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScenesScript : MonoBehaviour {

    public GameObject _lights;
    public GameObject _ceiling;

    private void Awake()
    {
        _lights.SetActive(false);
        _ceiling.SetActive(true);
    }
}
