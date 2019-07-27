using UnityEngine;
public class PixelGameBehaviour : MonoBehaviour
{
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
