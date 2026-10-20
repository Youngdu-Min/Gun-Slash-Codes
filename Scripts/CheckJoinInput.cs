using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{
    public class CheckJoinInput : MonoBehaviour
    {
        MultiplayerLevelManager multiplayerLevelManager;
        public KeyCode Keyboard1 = KeyCode.J;
        public KeyCode Keyboard2 = KeyCode.Alpha1;
        public KeyCode Joystick1 = KeyCode.Joystick1Button2;
        public KeyCode Joystick2 = KeyCode.Joystick2Button2;
        public KeyCode Joystick3 = KeyCode.Joystick3Button2;
        public KeyCode Joystick4 = KeyCode.Joystick4Button2;

        // Start is called before the first frame update
        void Start()
        {
            multiplayerLevelManager = MultiplayerLevelManager.Instance.GetComponent<MultiplayerLevelManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(Keyboard1))
            {
                multiplayerLevelManager.PlayerJoin(nameof(Keyboard1));
            }
            else if (Input.GetKeyDown(Keyboard2))
            {
                multiplayerLevelManager.PlayerJoin(nameof(Keyboard2));
            }
            else if (Input.GetKeyDown(Joystick1))
            {
                multiplayerLevelManager.PlayerJoin(nameof(Joystick1));
            }
            else if (Input.GetKeyDown(Joystick2))
            {
                multiplayerLevelManager.PlayerJoin(nameof(Joystick2));
            }
            else if (Input.GetKeyDown(Joystick3))
            {
                multiplayerLevelManager.PlayerJoin(nameof(Joystick3));
            }
            else if (Input.GetKeyDown(Joystick4))
            {
                multiplayerLevelManager.PlayerJoin(nameof(Joystick4));
            }


        }
    }
}
