using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Convert.Length;

public class LengthConvertService : ILengthConvertService
{
    public ResultDto<decimal> Execute(LengthConvertDto input)
    {
        var valueInMeter = input.Value * input.From;
        var result = valueInMeter / input.To;

        return new ResultDto<decimal>()
        {
            IsSuccess = true,
            Message = "تبدیل با موفقیت انجام شد",
            Data = result
        };
    }
}