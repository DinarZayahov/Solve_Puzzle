using HoloToolkit.Unity;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;

namespace HoloToolkit.Unity.Examples
{
    public class Button_Receiver : InteractionReceiver
    {
        // main object with buttons
        public GameObject obj; 

        protected override void InputDown(GameObject but, InputEventData eventData)
        {
            Debug.Log(but.name + " : InputUp");
            
            int index = 0;

            /* x defines sides of polyhedron:
            0 is face;
            1 is right side;
            2 is back side;
            3 is left side;
            4 is bottom;
            5 is top;
             */
            int x = 0;

            // getting the index of button
            index = Get_Button_Index(but);

            // dividing index by number of buttons in one side we can determine the side where current button is located
            x = index / 4;

            /* taking the remainder of index we can determine that button:
             * 0 -> rotates up;
             * 1 -> rotates right;
             * 2 -> rotates down;
             * 3 -> rotates left;
             */
            index = index % 4;
            
            // call function according to where we need to rotate
            switch (index)
            {
                case 0:
                    Rotate_Up(obj,x);
                    break;
                case 1:
                    Rotate_Right(obj,x);
                    break;
                case 2:
                    Rotate_Down(obj,x);
                    break;
                case 3:
                    Rotate_Left(obj,x);
                    break;
            }
        }

       // call functions according to where the button is located

        public void Rotate_Up(GameObject obj,int x)
        {
            switch (x)
            {
                case 0:
                    obj.transform.Rotate(new Vector3(90, 0, 0));
                    break;
                case 1:
                    obj.transform.Rotate(new Vector3(0, 0, 90));
                    break;
                case 2:
                    obj.transform.Rotate(new Vector3(-90, 0, 0));
                    break;
                case 3:
                    obj.transform.Rotate(new Vector3(0, 0, -90));
                    break;
                case 4:
                    obj.transform.Rotate(new Vector3(90, 0, 0));
                    break;
                case 5:
                    obj.transform.Rotate(new Vector3(90, 0, 0));
                    break;
            }
        }

        public void Rotate_Right(GameObject obj,int x)
        {
            switch (x)
            {
                case 0:
                    obj.transform.Rotate(new Vector3(0, -90, 0));
                    break;
                case 1:
                    obj.transform.Rotate(new Vector3(0, -90, 0));
                    break;
                case 2:
                    obj.transform.Rotate(new Vector3(0, -90, 0));
                    break;
                case 3:
                    obj.transform.Rotate(new Vector3(0, -90, 0));
                    break;
                case 4:
                    obj.transform.Rotate(new Vector3(0, 0, -90));
                    break;
                case 5:
                    obj.transform.Rotate(new Vector3(0, 0, 90));
                    break;
            }
        }

        public void Rotate_Left(GameObject obj,int x)
        {
            switch (x)
            {
                case 0:
                    obj.transform.Rotate(new Vector3(0, 90, 0));
                    break;
                case 1:
                    obj.transform.Rotate(new Vector3(0, 90, 0));
                    break;
                case 2:
                    obj.transform.Rotate(new Vector3(0, 90, 0));
                    break;
                case 3:
                    obj.transform.Rotate(new Vector3(0, 90, 0));
                    break;
                case 4:
                    obj.transform.Rotate(new Vector3(0, 0, 90));
                    break;
                case 5:
                    obj.transform.Rotate(new Vector3(0, 0, -90));
                    break;
            }
        }

        public void Rotate_Down(GameObject obj,int x)
        {
            switch (x)
            {
                case 0:
                    obj.transform.Rotate(new Vector3(-90, 0, 0));
                    break;
                case 1:
                    obj.transform.Rotate(new Vector3(0, 0, 90));
                    break;
                case 2:
                    obj.transform.Rotate(new Vector3(-90, 0, 0));
                    break;
                case 3:
                    obj.transform.Rotate(new Vector3(0, 0, -90));
                    break;
                case 4:
                    obj.transform.Rotate(new Vector3(90, 0, 0));
                    break;
                case 5:
                    obj.transform.Rotate(new Vector3(90, 0, 0));
                    break;
            }
        }

        // find and return the index of button in Interactables array
        public int Get_Button_Index(GameObject but)
        {
            for (int i = 0; i < interactables.Capacity; i++)
            {
                if (but.name.Equals(interactables[i].name))
                {
                    return i;
                }
            }
            return 0;
        }

        protected override void FocusEnter(GameObject obj, PointerSpecificEventData eventData)
        {
            Debug.Log(obj.name + " : FocusEnter");
        }

        protected override void FocusExit(GameObject obj, PointerSpecificEventData eventData)
        {
            Debug.Log(obj.name + " : FocusExit");
        }

        protected override void InputUp(GameObject obj, InputEventData eventData)
        {
            Debug.Log(obj.name + " : InputUp");
        }
    }
}
