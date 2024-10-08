using ElProjectGrande.Models;
using ElProjectGrande.Models.QuestionModels;
using ElProjectGrande.Models.QuestionModels.DTOs;
using ElProjectGrande.Models.UserModels;

namespace ElProjectGrande.Services.QuestionServices.Factory;

public class QuestionFactory : IQuestionFactory
{
    public Question CreateQuestion(NewQuestion newQuestion, User user)
    {
        return new Question
        {
            Title = newQuestion.Title, Content = newQuestion.Content, Id = Guid.NewGuid(), User = user,
            UserId = user.Id, PostedAt = newQuestion.PostedAt, Answers = [], Tags = newQuestion.Tags
        };
    }

    public Question CreateNewUpdatedQuestionFromUpdatesAndOriginal(UpdatedQuestion updatedQuestion, Question question)
    {
        question.Title = updatedQuestion.Title;
        question.Content = updatedQuestion.Content;
        return question;
    }
}