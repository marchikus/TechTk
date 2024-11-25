using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Game/Settings", order = 1)]
public class GameSettings : ScriptableObject
{
    [Tooltip("���� ��������� ������ �� ������ (�� 0 �� 1)")]
    [Range(0f, 1f)]
    public float goldSpawnChance = 0.5f;

    [Tooltip("������������ ������� ������")]
    public int maxDepth = 10;

    [Header("Cell Settings")]
    [Tooltip("���������� ����� � �����")]
    public int gridRows = 5;

    [Tooltip("���������� �������� � �����")]
    public int gridColumns = 5;
}
