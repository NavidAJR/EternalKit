using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Text.WordCounter;

public interface IWordCounterService
{
    ResultDto<int> Execute(string text);
}