using Note2Quiz.API.Services.OpenAI.Models;

namespace Note2Quiz.API.Services.OpenAI;

public static class QuizOptionShuffler
{
    public static void Shuffle(QuizGenResponse model)
    {
        if (model?.Questions == null || model.Questions.Count == 0)
            return;

        foreach (var question in model.Questions)
        {
            ShuffleQuestion(question);
        }
    }

    private static void ShuffleQuestion(QuizGenQuestion question)
    {
        if (question.Options == null || question.Options.Count < 2)
            return;

        var indexedOptions = question.Options
            .Select((option, index) => new OptionItem(option, index))
            .ToList();

        for (var i = indexedOptions.Count - 1; i > 0; i--)
        {
            var j = Random.Shared.Next(i + 1);
            (indexedOptions[i], indexedOptions[j]) = (indexedOptions[j], indexedOptions[i]);
        }

        question.Options = indexedOptions
            .Select(x => x.Text)
            .ToList();

        question.CorrectOptionIndex = indexedOptions
            .FindIndex(x => x.OriginalIndex == question.CorrectOptionIndex);
    }

    private sealed record OptionItem(string Text, int OriginalIndex);
}