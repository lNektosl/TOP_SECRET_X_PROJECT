using Assets.Scripts.Grid;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid {

    public CustomNode[,] Grid {  get; private set; }

    public CustomGrid(int width, int height) {
        Grid = new CustomNode[width, height];
        InitialiseGrid();
    }

    private void InitialiseGrid() {
        for(int i = 0; i < Grid.GetLength(0) ; i++) {
            for(int j = 0; j < Grid.GetLength(1); j++) {
                Grid[i,j] = new CustomNode(i,j);
            }
        }
    }
}
