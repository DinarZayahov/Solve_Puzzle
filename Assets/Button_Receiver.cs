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
                interactables[i].transform.position = obj.transform.TransformPoint(positions[i]);
                interactables[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y, obj.transform.rotation.eulerAngles.z - i%4*90);
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

            index = Get_Button_Index(but);
            
           
            index = index % 4;
            switch (index)
            {
                case 0:
                    Rotate_Up(obj);
                    break;
                case 1:
                    Rotate_Right(obj);
                    break;
                case 2:
                    Rotate_Down(obj);
                    break;
                case 3:
                    Rotate_Left(obj);
                    break;
            }
            
        }

        protected override void InputUp(GameObject obj, InputEventData eventData)
        {
            Debug.Log(obj.name + " : InputUp");
            
        }

        public void Rotate_Up(GameObject obj)
        {
            obj.transform.Rotate(new Vector3(90, 0, 0));
        }

        public void Rotate_Right(GameObject obj)
        {
            obj.transform.Rotate(new Vector3(0, -90, 0));
        }

        public void Rotate_Left(GameObject obj)
        {
            obj.transform.Rotate(new Vector3(0, 90, 0));
        }

        public void Rotate_Down(GameObject obj)
        {
            obj.transform.Rotate(new Vector3(-90, 0, 0));
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
