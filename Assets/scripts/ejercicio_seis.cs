using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_seis : MonoBehaviour
{

    // EJ 6.1
    private bool X = true;
    private bool Y = false;
    private bool Z = true;

    // EJ 6.2
    private bool W = false;
    private bool X2 = true;
    private bool Y2 = true;
    private bool Z2 = false;

    void Start()
    {
        // EJ 6.1

        // a) (X && Y) || (X && Z)
        bool resultado_a = (X && Y) || (X && Z);
        Debug.Log("6.1.a: (X && Y) || (X && Z) = " + resultado_a);

        // b) (X || !Y) && (!X || Z)
        bool resultado_b = (X || !Y) && (!X || Z);
        Debug.Log("6.1.b: (X || !Y) && (!X || Z) = " + resultado_b);

        // c) X || Y && Z
        bool resultado_c = X || (Y && Z);
        Debug.Log("6.1.c: X || Y && Z = " + resultado_c);

        // d) (X || Y) && Z
        bool resultado_d = (X || Y) && Z;
        Debug.Log("6.1.d: (X || Y) && Z = " + resultado_d);

        // e) X | Y || (X && !Z && !Y)
        bool resultado_e = X | Y || (X && !Z && !Y);
        Debug.Log("6.1.e: X | Y || (X && !Z && !Y) = " + resultado_e);

        // f) !X | Y | Z && X && !Y
        bool resultado_f = !X | Y | (Z && X && !Y);
        Debug.Log("6.1.f: !X | Y | Z && X && !Y = " + resultado_f);


        // EJ 6.2

        // a) W && X2 && W || Z2
        bool resultado_a2 = W && X2 && W || Z2;
        Debug.Log("6.2.a: W && X2 && W || Z2 = " + resultado_a2);

        // b) X2 && !Y2 && !X2 || (!W && Y2)
        bool resultado_b2 = X2 && !Y2 && !X2 || (!W && Y2);
        Debug.Log("6.2.b: X2 && !Y2 && !X2 || (!W && Y2) = " + resultado_b2);

        // c) (W || !Y2) && X2 || Z2
        bool resultado_c2 = (W || !Y2) && X2 || Z2;
        Debug.Log("6.2.c: (W || !Y2) && X2 || Z2 = " + resultado_c2);

        // d) X2 && Y2 && W || Z2 || X2
        bool resultado_d2 = X2 && Y2 && W || Z2 || X2;
        Debug.Log("6.2.d: X2 && Y2 && W || Z2 || X2 = " + resultado_d2);

        // e) Y2 || !(Y2 || Z2 && W)
        bool resultado_e2 = Y2 || !(Y2 || Z2 && W);
        Debug.Log("6.2.e: Y2 || !(Y2 || Z2 && W) = " + resultado_e2);

        // f) !X2 && Y2 && (!Z2 || !X2)
        bool resultado_f2 = !X2 && Y2 && (!Z2 || !X2);
        Debug.Log("6.2.f: !X2 && Y2 && (!Z2 || !X2) = " + resultado_f2);
    }
    void Update()
    {

    }
}

