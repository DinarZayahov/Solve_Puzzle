using HoloToolkit.Unity;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;

namespace HoloToolkit.Unity.Examples
{
    public class Button_Receiver : InteractionReceiver
    {
        public GameObject obj;
        public Vector3[] positions;

        void Start()
        {

        }

        private void Update()
        {
            for (int i = 0; i < interactables.Capacity; i++)
            {
                int x = i / 4;
                switch (x)
                {
                    case 0:
                        interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y, obj.transform.rotation.eulerAngles.z - i % 4 * 90);
                        break;
                    case 1:
                        interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y+90, obj.transform.rotation.eulerAngles.z + i % 4 * 90);
                        break;
                    case 2:
                        interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y-180, obj.transform.rotation.eulerAngles.z - i % 4 * 90);
                        break;
                    case 3:
                        interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y+90, obj.transform.rotation.eulerAngles.z - i % 4 * 90);
                        break;
                    case 4:
                        interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x+90, obj.transform.rotation.eulerAngles.y, obj.transform.rotation.eulerAngles.z - i % 4 * 90);
                        break;
                    case 5:
                        interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x-90, obj.transform.rotation.eulerAngles.y, obj.transform.rotation.eulerAngles.z - i % 4 * 90);
                        break;
                }
                interactables[i].transform.position = obj.transform.TransformPoint(positions[i]);
                //interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y, obj.transform.rotation.eulerAngles.z - i%4*90);
            }
        }

        protected override void FocusEnter(GameObject obj, PointerSpecificEventData eventData)
        {
            Debug.Log(obj.name + " : FocusEnter");
            
        }

        protected override void FocusExit(GameObject obj, PointerSpecificEventData eventData)
        {
            Debug.Log(obj.name + " : FocusExit");
            
        }

        protected override void InputDown(GameObject but, InputEventData eventData)
        {
            Debug.Log(but.name + " : InputUp");
            
            int index = 0;
            int x = 0;
            index = Get_Button_Index(but);

            x = index / 4;
            index = index % 4;
            
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

        protected override void InputUp(GameObject obj, InputEventData eventData)
        {
            Debug.Log(obj.name + " : InputUp");
            
        }

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
    }
}
