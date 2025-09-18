using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    // Base Question class
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }

        protected Question(int id, string header, string body, int marks)
        {
            Id = id;
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList();
        }

        // Constructor chaining
        protected Question() : this(0, "", "", 0) { }

        public abstract void Show();
        public abstract string GetQuestionType();

        public override string ToString() => $"{Header}: {Body}. ({Marks} Marks)";

        public override bool Equals(object obj)
        {
            if (obj is Question other)
            {
                return Id == other.Id && Header == other.Header && Body == other.Body && Marks == other.Marks;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Header, Body, Marks);
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return Id.CompareTo(other.Id);
        }
    }

    // True/False Question
    public class QuestionTF : Question
    {
        public QuestionTF(int id, string header, string body, int marks) : base(id, header, body, marks)
        {
        }

        public QuestionTF() : base() { }

        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body}");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }

        public override string GetQuestionType()
        {
            return "True/False";
        }
    }

    // Choose One Question
    public class QuestionChooseOne : Question
    {
        public QuestionChooseOne(int id, string header, string body, int marks) : base(id, header, body, marks)
        {
        }

        public QuestionChooseOne() : base() { }

        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body}");
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].Body}");
            }
        }

        public override string GetQuestionType()
        {
            return "Choose One";
        }
    }

    // Choose All Question
    public class QuestionChooseAll : Question
    {
        public QuestionChooseAll(int id, string header, string body, int marks) : base(id, header, body, marks)
        {
        }

        public QuestionChooseAll() : base() { }

        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body}");
            Console.WriteLine("(Select all that apply)");
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].Body}");
            }
        }

        public override string GetQuestionType()
        {
            return "Choose All";
        }
    }

    // QuestionList with file logging
    public class QuestionList : List<Question>
    {
        private readonly string _filePath;

        public QuestionList(string filePath)
        {
            _filePath = filePath;
            // Create the file if it doesn't exist
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }

        public new void Add(Question question)
        {
            base.Add(question);
            
            // Log to file
            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine($"Question ID: {question.Id}");
                sw.WriteLine($"Type: {question.GetQuestionType()}");
                sw.WriteLine($"Header: {question.Header}");
                sw.WriteLine($"Body: {question.Body}");
                sw.WriteLine($"Marks: {question.Marks}");
                sw.WriteLine($"Answers: {question.Answers.Count}");
                sw.WriteLine("---");
            }
        }

        public new void Remove(Question question)
        {
            base.Remove(question);
        }

        public new void Clear()
        {
            base.Clear();
        }
    }
}
