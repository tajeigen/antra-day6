namespace hw_day6;

public class Ball
{
    private int _size;
    private Color _color;
    private int _throwCount;

    public Ball(int size, Color color)
    {
        _size = size;
        _color = color;
        _throwCount = 0;
    }

    public void Pop()
    {
        _size = 0;
    }

    public void Throw()
    {
        if (_size > 0)
        {
            _throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return _throwCount;
    }

}