using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FPS
{
    public class FlashlightViewText : MonoBehaviour
    {

        private Text _text;
        private FleshLightModel _fleshLightModel;

        private void Awake()
        {
            _text = GetComponent<Text>();
            _fleshLightModel = FindObjectOfType<FleshLightModel>();
        }

        //Нет смысла делать обновление UI элементов в FixedUpdate. 
        //Т.к. FixedUpdate может быть вызван и 2 раза за кадр, обновление произойдет 2 раза, при этом отобразиться на экране только 1 кадр.
        private void Update()
        {
            _text.text = _fleshLightModel._energy.ToString();
        }
    }
}
