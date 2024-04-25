using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public VideoPlayerEndReachedEvent VidEnd;
    // Start is called before the first frame update
    void Start()
    {
        VidEnd.endReach = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(VidEnd.endReach);
        /*f (VidEnd.endReach == true);
        {
            print(VidEnd.endReach);
            print("camera " + Camera.main.transform.position);
            //print("renderTexture " + videoOutput.transform.position);
            //Camera.main.transform.Translate(1500, 0, 0);
            VidEnd.endReach = false;
        }*/
    }
}
