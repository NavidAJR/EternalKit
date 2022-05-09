using EternalKit.Application.Dto;

namespace EternalKit.Application.Services.Text.CharacterCounter;

public interface ICharacterCounterService
{
    ResultDto<long> Execute(string text, bool countSpace, bool countPunctuationCharacters);
}