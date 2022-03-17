using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyClap.HospitalRun
{
    public class CurvedShader : MonoBehaviour
    {
	    public float curvature;
	    public float trimming;
	    private void Awake()
	    {
		    Shader.SetGlobalFloat("_Curvature", curvature);
		    Shader.SetGlobalFloat("_Trimming", trimming);
	    }
    }
}
