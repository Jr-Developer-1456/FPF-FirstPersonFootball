using UnityEngine;

public class Followers : MonoBehaviour
{
    public Transform Camera;
    public Transform headBone;
    public Vector3 offset = new Vector3(0f,0.07f,0.22f);

    void Update()
    {
        CameraFollowHeadbone();
    }
    void CameraFollowHeadbone(){
    transform.position = headBone.position + headBone.TransformDirection(offset);
    /*Camera.transform.rotation= headBone.rotation;*/
    }
}