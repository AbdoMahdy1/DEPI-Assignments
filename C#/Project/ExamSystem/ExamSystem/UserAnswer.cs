using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class UserAnswer : ICloneable, IComparable<UserAnswer>
    {
        public Question Question { get; set; }
        public List<int> SelectedAnswerIds { get; set; }
        public DateTime AnsweredAt { get; set; }
        public bool IsCorrect { get; set; }
        public int Score { get; set; }

        public UserAnswer(Question question)
        {
            Question = question;
            SelectedAnswerIds = new List<int>();
            AnsweredAt = DateTime.Now;
            IsCorrect = false;
            Score = 0;
        }

        // Constructor chaining
        public UserAnswer() : this(null) { }

        public void AddAnswer(int answerId)
        {
            if (!SelectedAnswerIds.Contains(answerId))
            {
                SelectedAnswerIds.Add(answerId);
            }
        }

        public void RemoveAnswer(int answerId)
        {
            SelectedAnswerIds.Remove(answerId);
        }

        public void ClearAnswers()
        {
            SelectedAnswerIds.Clear();
        }

        public bool HasAnswer(int answerId)
        {
            return SelectedAnswerIds.Contains(answerId);
        }

        public void CalculateScore(AnswerList correctAnswers)
        {
            if (Question is QuestionTF || Question is QuestionChooseOne)
            {
                // For True/False and Choose One, only one answer should be selected
                if (SelectedAnswerIds.Count == 1)
                {
                    var selectedAnswer = correctAnswers.FirstOrDefault(a => a.Id == SelectedAnswerIds[0]);
                    IsCorrect = selectedAnswer?.IsCorrect ?? false;
                    Score = IsCorrect ? Question.Marks : 0;
                }
                else
                {
                    IsCorrect = false;
                    Score = 0;
                }
            }
            else if (Question is QuestionChooseAll)
            {
                // For Choose All, check if all correct answers are selected and no incorrect ones
                var correctAnswerIds = correctAnswers.Where(a => a.IsCorrect).Select(a => a.Id).ToList();
                var incorrectAnswerIds = correctAnswers.Where(a => !a.IsCorrect).Select(a => a.Id).ToList();
                
                bool allCorrectSelected = correctAnswerIds.All(id => SelectedAnswerIds.Contains(id));
                bool noIncorrectSelected = !incorrectAnswerIds.Any(id => SelectedAnswerIds.Contains(id));
                
                IsCorrect = allCorrectSelected && noIncorrectSelected;
                Score = IsCorrect ? Question.Marks : 0;
            }
        }

        public string GetSelectedAnswersText(AnswerList allAnswers)
        {
            if (SelectedAnswerIds.Count == 0)
                return "No answer selected";

            var selectedAnswers = allAnswers.Where(a => SelectedAnswerIds.Contains(a.Id)).ToList();
            return string.Join(", ", selectedAnswers.Select(a => a.Body));
        }

        public string GetCorrectAnswersText(AnswerList allAnswers)
        {
            var correctAnswers = allAnswers.Where(a => a.IsCorrect).ToList();
            return string.Join(", ", correctAnswers.Select(a => a.Body));
        }

        public override string ToString()
        {
            return $"Question: {Question?.Body} | Selected: [{string.Join(", ", SelectedAnswerIds)}] | Correct: {IsCorrect} | Score: {Score}";
        }

        public override bool Equals(object obj)
        {
            if (obj is UserAnswer other)
            {
                return Question?.Id == other.Question?.Id && 
                       SelectedAnswerIds.SequenceEqual(other.SelectedAnswerIds);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Question?.Id, SelectedAnswerIds);
        }

        public object Clone()
        {
            var cloned = (UserAnswer)MemberwiseClone();
            cloned.SelectedAnswerIds = new List<int>(SelectedAnswerIds);
            return cloned;
        }

        public int CompareTo(UserAnswer other)
        {
            if (other == null) return 1;
            return Question?.Id.CompareTo(other.Question?.Id) ?? 0;
        }
    }

    public class UserAnswerList : List<UserAnswer>
    {
        public UserAnswerList() : base() { }

        public UserAnswerList(IEnumerable<UserAnswer> userAnswers) : base(userAnswers) { }

        public UserAnswer GetAnswerForQuestion(Question question)
        {
            return this.FirstOrDefault(ua => ua.Question?.Id == question.Id);
        }

        public int GetTotalScore()
        {
            return this.Sum(ua => ua.Score);
        }

        public int GetMaxPossibleScore()
        {
            return this.Sum(ua => ua.Question?.Marks ?? 0);
        }

        public double GetPercentage()
        {
            var maxScore = GetMaxPossibleScore();
            if (maxScore == 0) return 0;
            return (double)GetTotalScore() / maxScore * 100;
        }

        public int GetCorrectAnswersCount()
        {
            return this.Count(ua => ua.IsCorrect);
        }

        public int GetTotalQuestionsCount()
        {
            return this.Count;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"Total Score: {GetTotalScore()}/{GetMaxPossibleScore()} ({GetPercentage():F1}%)");
            result.AppendLine($"Correct Answers: {GetCorrectAnswersCount()}/{GetTotalQuestionsCount()}");
            result.AppendLine();
            
            foreach (var userAnswer in this)
            {
                result.AppendLine(userAnswer.ToString());
            }
            
            return result.ToString();
        }
    }
}
