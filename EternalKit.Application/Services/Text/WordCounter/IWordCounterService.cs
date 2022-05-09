using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Text.WordCounter;

public interface IWordCounterService
{
    ResultDto<long> Execute(string text, bool countPunctuationCharacters);
}