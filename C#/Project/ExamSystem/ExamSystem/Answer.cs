using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public bool IsCorrect { get; set; }

        public Answer(int id, string body, bool isCorrect)
        {
            Id = id;
            Body = body;
            IsCorrect = isCorrect;
        }

        // Constructor chaining
        public Answer() : this(0, "", false) { }

        public override string ToString()
        {
            return $"{Id}. {Body}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Answer other)
            {
                return Id == other.Id && Body == other.Body && IsCorrect == other.IsCorrect;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Body, IsCorrect);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Answer other)
        {
            if (other == null) return 1;
            return Id.CompareTo(other.Id);
        }
    }

    public class AnswerList : List<Answer>
    {
        public AnswerList() : base() { }

        public AnswerList(IEnumerable<Answer> answers) : base(answers) { }

        public new void Add(Answer answer)
        {
            base.Add(answer);
        }

        public new void Remove(Answer answer)
        {
            base.Remove(answer);
        }

        public new void Clear()
        {
            base.Clear();
        }

        public List<Answer> GetCorrectAnswers()
        {
            return this.Where(a => a.IsCorrect).ToList();
        }

        public List<Answer> GetIncorrectAnswers()
        {
            return this.Where(a => !a.IsCorrect).ToList();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var answer in this)
            {
                result.AppendLine(answer.ToString());
            }
            return result.ToString();
        }
    }
}
