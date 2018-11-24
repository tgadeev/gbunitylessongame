using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class ClickController : BaseController
    {

        public void Click()
        {
            print("Упс, тут что-то проихошло =)");
            //Ray MyRay = Camera.main.ScreenPointToRay(new Vector3(0,0,1));
            //Debug.DrawRay(MyRay.origin, MyRay.direction * 10, Color.yellow);
        }
    }
}
