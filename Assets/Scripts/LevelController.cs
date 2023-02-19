using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;

    public event EventHandler<int> OnLevelChanged;

    private void Awake()
    {
        Instance = this;
    }

    [Header("LevelWalls")]
    [SerializeField] private GameObject level1Wall;
    [SerializeField] private GameObject level2Wall;
    [SerializeField] private GameObject level3Wall;
    [SerializeField] private GameObject level4Wall;
    // Unused
    //[SerializeField] public GameObject level5Wall;
    [Header("Camera")]
    [SerializeField] private CinemachineVirtualCamera virtualCamera1;
    [SerializeField] private CinemachineVirtualCamera virtualCamera2;
    [SerializeField] private CinemachineVirtualCamera virtualCamera3;
    [SerializeField] private CinemachineVirtualCamera virtualCamera4;
    //[SerializeField] private Transform cameraPosition1;
    //[SerializeField] private Transform cameraPosition2;
    //[SerializeField] private Transform cameraPosition3;
    [Header("Goals")]
    [SerializeField] private GameObject goal2;
    [SerializeField] private GameObject goal3;
    [SerializeField] private GameObject goal4;
    [SerializeField] private GameObject goal5;
    [Header("Scene objects")]
    [SerializeField] private GameEnd gameEnd;
    [SerializeField] private Player player;
    [Header("GameObjects")]
    [SerializeField] public Transform completedGoal;
    [SerializeField] public Transform goalParticles;

    private void Start()
    {
        goal2.SetActive(false);
        goal3.SetActive(false);
        goal4.SetActive(false);
        goal5.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void LevelCleared(int level)
    {
        OnLevelChanged?.Invoke(this, level);
        switch (level)
        {
            case 0:
                virtualCamera1.m_Priority = 1;
                break;
            case 1:
                level1Wall.SetActive(false);
                Instantiate(goalParticles, goal2.transform.position, Quaternion.identity);
                goal2.SetActive(true);
                virtualCamera2.m_Priority = 11;
                break;
            case 2:
                level2Wall.SetActive(false);
                Instantiate(goalParticles, goal3.transform.position, Quaternion.identity);
                goal3.SetActive(true);
                break;
            case 3:
                level3Wall.SetActive(false);
                Instantiate(goalParticles, goal4.transform.position, Quaternion.identity);
                goal4.SetActive(true);
                break;
            case 4:
                level4Wall.SetActive(false);
                Instantiate(goalParticles, goal5.transform.position, Quaternion.identity);
                goal5.SetActive(true);
                virtualCamera3.m_Priority = 12;
                break;
            case 5:
                // Game COMPLETE
                virtualCamera4.m_Priority = 13;
                gameEnd.gameObject.SetActive(true);
                Destroy(player.gameObject);
                break;
            default:
                Debug.Log("Error, no such level.");
                break;
        }
    }
}
