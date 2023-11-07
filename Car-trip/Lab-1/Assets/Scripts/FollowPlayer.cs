using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This follow player class will make the camera follow the vehicle player.
/// Standar coding documentarion can be found in 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
/// </summary>

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,6,-7);
    
    /// <summary>
    /// This method is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// This method is called once per frame
    /// </summary>
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
