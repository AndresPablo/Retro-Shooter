using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName ="New Rule Tile", menuName = "Tiles/Rule Tile")]
public class GameRuleTile : RuleTile
{
    public Color color = Color.white;
    public TileType type;
}

[System.Serializable]
public enum TileType
{
    Tierra,
    Cesped,
    Piedra,
    Metal,
    Agua,
    Acido,
    Lava
}