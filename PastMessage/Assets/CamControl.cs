using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 �J�������R���g���[�����邽�߂̃X�N���v�g�B

�v���C���[��ǂ�������
�����ɂ͒ǂ��������A�����̃}�[�W���������Ēǂ�������
 */
public class CamControl : MonoBehaviour
{
    public GameObject tracedObj;
    private float CAM_DIST = 20;//�J���������鋗���B���s�����Ȃ̂ŋ߂Â��Ă��g�傳��Ȃ��B
    private float CAM_HEIGHT_ANGLE = 30;//�J������������x�̈ʒu����f�����B
    private float CAM_HORIZON_ANGLE = 45;
    private float camSize = 3.11f;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(CAM_HEIGHT_ANGLE, 90-CAM_HORIZON_ANGLE, 0);
        //-x,-z������45���Ay�����ɏ��30��
        float bottom = CAM_DIST * Mathf.Cos(CAM_HEIGHT_ANGLE * Mathf.Deg2Rad);
        Vector3 cameraDiff = new Vector3(-(bottom*Mathf.Cos(CAM_HORIZON_ANGLE*Mathf.Deg2Rad)), CAM_DIST * Mathf.Sin(CAM_HEIGHT_ANGLE * Mathf.Deg2Rad), -(bottom * Mathf.Sin(CAM_HORIZON_ANGLE * Mathf.Deg2Rad)));
        transform.position = tracedObj.transform.position + cameraDiff;
    }
}
