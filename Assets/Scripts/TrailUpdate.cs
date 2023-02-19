using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class TrailUpdate : MonoBehaviour
{
    private TrailRenderer trailRenderer;

    [Header("Trails")]
    [SerializeField] private GameObject trail0;
    [SerializeField] private GameObject trail1;
    [SerializeField] private GameObject trail2;
    [SerializeField] private GameObject trail3;
    [SerializeField] private GameObject trail4;

    private void Awake()
    {
        trailRenderer = GetComponent<TrailRenderer>();
    }

    private void Start()
    {
        LevelController.Instance.OnLevelChanged += LevelController_OnLevelChanged;
    }

    private void OnDestroy()
    {
        LevelController.Instance.OnLevelChanged -= LevelController_OnLevelChanged;
    }

    private void LevelController_OnLevelChanged(object sender, int e)
    {
        //DisableAllTrails();
        switch (e)
        {
            case 0:
                trail0.SetActive(true);
                break;
            case 1:
                trail1.SetActive(true);
                break;
            case 2:
                trail2.SetActive(true);
                break;
            case 3:
                trail3.SetActive(true);
                break;
            case 4:
                trail4.SetActive(true);
                break;
            case 5:
                // Game COMPLETE
                break;
            default:
                Debug.Log("Error, no such level.");
                break;
        }
    }

    private void DisableAllTrails()
    {
        trail0.SetActive(false);
        trail1.SetActive(false);
        trail2.SetActive(false);
        trail3.SetActive(false);
        trail4.SetActive(false);
    }
}
