using UnityEngine;
using UnityEngine.UI; // Importa el espacio de nombres UI

#pragma warning disable 618

namespace UnityStandardAssets.Utility
{
    public class SimpleActivatorMenu : MonoBehaviour
    {
        // Un menú increíblemente simple que, cuando se le dan referencias
        // a gameobjects en la escena
        public Text camSwitchButton; // Cambia el tipo de variable a Text
        public GameObject[] objects;

        private int m_CurrentActiveObject;

        private void OnEnable()
        {
            // El objeto activo comienza desde el primero en el array
            m_CurrentActiveObject = 0;
            camSwitchButton.text = objects[m_CurrentActiveObject].name;
        }

        public void NextCamera()
        {
            int nextactiveobject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == nextactiveobject);
            }

            m_CurrentActiveObject = nextactiveobject;
            camSwitchButton.text = objects[m_CurrentActiveObject].name;
        }
    }
}
