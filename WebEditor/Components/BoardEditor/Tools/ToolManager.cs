using CaptainCoder.TacticsEngine.Board;

namespace WebEditor.Components.BoardEditor;

public class ToolManager
{
    internal static ToolManager Shared { get; } = new();
    private Tool _tool = TileTool.Shared;
    public Tool Tool
    {
        get => _tool;
        set
        {
            if (_tool == value) { return; }
            _tool = value;
            OnChange?.Invoke(_tool);
        }
    }
    public event Action<Tool>? OnChange;
    public void SelectTile(Board board, Position position)
    {
        _tool.OnSelectTile(board, position);
    }

    public void MouseOver(Board board, Position position)
    {
        _tool.OnMouseOver(board, position);
    }

    public void SelectFigure(Board board, Positioned<Figure> figure)
    {
        _tool.OnSelectFigure(board, figure);
    }

    public void StartDragFigure(Board board, Positioned<Figure> figure)
    {
        _tool.OnStartDragFigure(board, figure);
    }

    public void MouseUp(Board board, Position position)
    {
        _tool.OnMouseUp(board, position);
    }
}