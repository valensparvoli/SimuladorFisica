using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;
    public InputField inputFuerza;
    public InputField inputMassa;

    public Text fuerzaAplicadatxt;
    public Text massaAplicadatxt;

    public int fuerzaAplicada;
    public int massaEsfera;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 6, 0);
    }

    public void UpdateBallForce()
    {
        int fuerza;
        int.TryParse(inputFuerza.text, out fuerza);
        fuerzaAplicada = fuerza;
        fuerzaAplicadatxt.text = inputFuerza.text;
    }
    
    public void UpdateMassBall()
    {
        int massa;
        int.TryParse(inputMassa.text, out massa);
        massaEsfera = massa;
        massaAplicadatxt.text = inputMassa.text;
    }

    public void MoveBall()
    {
        rb.mass = massaEsfera;
        rb.AddForce(-transform.up * fuerzaAplicada);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Simulacion");
    }
}
