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
        for(int i = 0; i < GridWidth; i++) {
            for(int j = 0; j < GridHeight; j++) {
                Instantiate(CustomNodePrefab,Grid.Grid[i,j].NodeToWorldPositionV3(),quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
