using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class SEControler : MonoBehaviour
{
    [SerializeField] AudioClip[] clips;
    [SerializeField] bool randomizePitch = true;
    [SerializeField] float pitchRange = 0.1f;

    protected AudioSource source;

    private void Awake()
    {
        // �A�^�b�`�����I�[�f�B�I�\�[�X�̂���1�Ԗڂ��g�p����
        source = GetComponents<AudioSource>()[0];
    }

    public void PlayFootstepSE()
    {
        if (randomizePitch)
            source.pitch = 1.0f + Random.Range(-pitchRange, pitchRange);

        source.PlayOneShot(clips[Random.Range(0, clips.Length)]);
    }

}