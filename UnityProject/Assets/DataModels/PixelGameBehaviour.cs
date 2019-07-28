using UnityEngine;
using System.Collections.Generic;
using PixelGames;
public class PixelGameBehaviour : MonoBehaviour
{
    List<PgObject> ActiveObjects = new List<PgObject>();
    List<PgObject> InactiveObjects = new List<PgObject>();
    
    IEnumerator MainLoop()
    {
        while (true)
        {
            try
            {
                // main Loop of this game ... 
                yield return null;
            }
            catch (System.Exception e)
            {
                Debug.LogError(string.Concat("There was a Exception like : {0}", e.Message));
                Debug.Break(); // Pause in editor. 
            }

        }
    }


}
