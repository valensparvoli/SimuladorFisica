using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plataforma : MonoBehaviour
{
    public InputField inputFuerza;
    public InputField inputMass;

    public Text fuerzaPlataformaTxt;
    public Text massaPlataformaTxt;

    public Joint joint;

    void Start()
    {
        joint = GetComponent<Joint>();

    }

    public void updateJointStrenght()
    {
        int fuerza;
        int.TryParse(inputFuerza.text, out fuerza);
        joint.breakForce = fuerza;
        fuerzaPlataformaTxt.text = inputFuerza.text;
    }

    public void updateJointMass()
    {
        int mass;
        int.TryParse(inputMass.text, out mass);
        joint.massScale = mass;
        massaPlataformaTxt.text = inputMass.text;
    }
}
