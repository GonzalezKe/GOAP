using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public sealed class GWorld 
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;

    static GWorld()
    {
        world = new WorldStates();
    }
    private GWorld()
    {

    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public  WorldStates GetWorld()
    {
        return world;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
