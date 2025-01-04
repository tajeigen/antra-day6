namespace hw_day6;

public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    // Constructor with all values
    public Color(int red, int green, int blue, int alpha)
    {
        SetRed(red);
        SetGreen(green);
        SetBlue(blue);
        SetAlpha(alpha);
    }

    // Constructor without alpha (defaults to 255)
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Getters and setters with validation
    public int GetRed() => _red;
    public int GetGreen() => _green;
    public int GetBlue() => _blue;
    public int GetAlpha() => _alpha;

    public void SetRed(int value)
    {
        if (value < 0 || value > 255)
            throw new ArgumentException("Red value must be between 0 and 255");
        _red = value;
    }

    public void SetGreen(int value)
    {
        if (value < 0 || value > 255)
            throw new ArgumentException("Green value must be between 0 and 255");
        _green = value;
    }

    public void SetBlue(int value)
    {
        if (value < 0 || value > 255)
            throw new ArgumentException("Blue value must be between 0 and 255");
        _blue = value;
    }

    public void SetAlpha(int value)
    {
        if (value < 0 || value > 255)
            throw new ArgumentException("Alpha value must be between 0 and 255");
        _alpha = value;
    }

    public int GetGrayscale()
    {
        return (_red + _green + _blue) / 3;
    }
}