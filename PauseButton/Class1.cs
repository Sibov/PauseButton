using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PauseButton
{

    public class Class1 : VTOLMOD
    {
        void Update()
        {
            if (Input.GetKey("p"))
            {
                SetPause();
            }
        }

        void SetPause()
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
