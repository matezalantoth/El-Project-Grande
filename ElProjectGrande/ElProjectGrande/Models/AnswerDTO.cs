namespace ElProjectGrande.Models;

public class AnswerDTO
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public string Username { get; set; }
    public DateTime PostedAt { get; set; }
    public QuestionDTO Question { get; set; }
    public int Votes { get; set; }

    public bool Accepted { get; set; }
}