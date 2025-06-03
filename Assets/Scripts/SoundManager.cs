using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }

    public AudioSource shootingSoundPistol;
    public AudioSource reloadingSoundPistol;
    public AudioSource emptyMagazineSoundPistol;

    public AudioClip ARShot;
    
    public AudioSource shootingSoundAR;
    public AudioSource reloadingSoundAR;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayShootingSound(WeaponModel weapon)
{
    switch (weapon)
    {
        case WeaponModel.Pistol:
            shootingSoundPistol.Play();
            break;

        case WeaponModel.AR:
            shootingSoundAR.PlayOneShot(ARShot);
            break;
    }
}

public void PlayReloadSound(WeaponModel weapon)
{
    switch (weapon)
    {
        case WeaponModel.Pistol:
            reloadingSoundPistol.Play();
            break;

        case WeaponModel.AR:
            reloadingSoundAR.Play();
            break;
    }
}}
