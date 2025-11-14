using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Grid {
    public class CustomNode {
        public Vector2 vector2 {  get; private set; }
        public CustomNode(int x,int y) {
            vector2 = new Vector2(x,y);
        }

        public Vector3 NodeToWorldPositionV3() {
            return new Vector3(vector2.x + 0.5f,vector2.y + 0.5f,0);
        }
    }
}
