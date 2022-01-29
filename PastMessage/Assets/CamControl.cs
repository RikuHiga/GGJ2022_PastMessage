using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 カメラをコントロールするためのスクリプト。

プレイヤーを追いかける
精密には追いかけず、多少のマージンを持って追いかける
 */
public class CamControl : MonoBehaviour
{
    public GameObject tracedObj;
    private float CAM_DIST = 20;//カメラがいる距離。平行透視なので近づいても拡大されない。
    private float CAM_HEIGHT_ANGLE = 30;//カメラが上方何度の位置から映すか。
    private float CAM_HORIZON_ANGLE = 45;
    private float camSize = 4f;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera=this.gameObject.GetComponent<Camera>();
        camera.orthographicSize = camSize;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(CAM_HEIGHT_ANGLE, 90-CAM_HORIZON_ANGLE, 0);
        float bottom = CAM_DIST * Mathf.Cos(CAM_HEIGHT_ANGLE * Mathf.Deg2Rad);
        Vector3 cameraDiff = new Vector3(-(bottom*Mathf.Cos(CAM_HORIZON_ANGLE*Mathf.Deg2Rad)), CAM_DIST * Mathf.Sin(CAM_HEIGHT_ANGLE * Mathf.Deg2Rad), -(bottom * Mathf.Sin(CAM_HORIZON_ANGLE * Mathf.Deg2Rad)));
        //transform.position = tracedObj.transform.position + cameraDiff;
        transform.position = Vector3.Lerp(transform.position, tracedObj.transform.position + cameraDiff, Time.deltaTime);

        //Vector3 viewportPos = camera.WorldToViewportPoint(tracedObj.transform.position);
    }
}
