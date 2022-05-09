using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Text.LineCounter;

public interface ILineCounterService
{
    ResultDto<long> Execute(string text);
}