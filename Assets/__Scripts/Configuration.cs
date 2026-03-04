using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**********************************
IGNORE THIS SCRIPT, IT IS NOT USED IN THE GAME.
This script is only used to demonstrate how to use 
ScriptableObjects to store configuration data.

***********************************/
[CreateAssetMenu(fileName = "Configuration", menuName = "Configuration")]
public class Configuration : ScriptableObject
{
    [field:SerializeField] public int Radius123 {get; private set;} = 4;
} 
