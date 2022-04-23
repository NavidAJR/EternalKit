namespace EternalKit.Application.Services.LengthConvert;

public class LengthConvertDto
{
    public decimal Value { get; set; }
    public decimal From { get; set; }
    public decimal To { get; set; }
    public int DigitsAfterDecimalPoint { get; set; }
    public decimal Result { get; set; }
}