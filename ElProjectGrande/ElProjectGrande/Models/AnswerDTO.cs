namespace ElProjectGrande.Models;

public class AnswerDTO
{
    public string Content { get; set; }
    public string Username { get; set; }
    public DateTime PostedAt { get; set; }
    public QuestionDTO Question { get; set; }
}