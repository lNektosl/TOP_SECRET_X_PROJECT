using Assets.Scripts.Grid;
using Unity.Mathematics;
using UnityEngine;

public class Initialiser : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject CustomNodePrefab;
    [SerializeField] int GridWidth;
    [SerializeField] int GridHeight;

    public CustomGrid Grid { get; private set; }
    void Start() {
        Grid = new CustomGrid(GridWidth,GridHeight);

        foreach(CustomNode node in Grid.Grid) {
            Instantiate(CustomNodePrefab,node.NodeToWorldPositionV3(),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
