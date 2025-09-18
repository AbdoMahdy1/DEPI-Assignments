using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }

    // Event and delegate for exam notifications
    public delegate void ExamEventHandler(object sender, ExamEventArgs e);

    public class ExamEventArgs : EventArgs
    {
        public Exam Exam { get; }
        public ExamMode PreviousMode { get; }
        public ExamMode CurrentMode { get; }

        public ExamEventArgs(Exam exam, ExamMode previousMode, ExamMode currentMode)
        {
            Exam = exam;
            PreviousMode = previousMode;
            CurrentMode = currentMode;
        }
    }

    // Base Exam class
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int NumOfQuestions { get; set; }
        public string Type { get; set; }
        public Subject Subject { get; set; }
        public QuestionList Questions { get; set; }
        public Dictionary<Question, AnswerList> QuestionAnswerDictionary { get; set; }
        public UserAnswerList UserAnswers { get; set; }
        
        private ExamMode _mode;
        public ExamMode Mode
        {
            get => _mode;
            set
            {
                if (_mode != value)
                {
                    var previousMode = _mode;
                    _mode = value;
                    OnModeChanged(previousMode, value);
                }
            }
        }

        // Events
        public event ExamEventHandler ExamStarted;
        public event ExamEventHandler ExamQueued;
        public event ExamEventHandler ExamFinished;

        protected Exam(int id, DateTime time, int numOfQuestions, string type, Subject subject)
        {
            Id = id;
            Time = time;
            NumOfQuestions = numOfQuestions;
            Type = type;
            Subject = subject;
            Questions = new QuestionList($"exam_{id}_questions.txt");
            QuestionAnswerDictionary = new Dictionary<Question, AnswerList>();
            UserAnswers = new UserAnswerList();
            Mode = ExamMode.Queued;
        }

        // Constructor chaining
        protected Exam() : this(0, DateTime.Now, 0, "", null) { }

        protected virtual void OnModeChanged(ExamMode previousMode, ExamMode currentMode)
        {
            var args = new ExamEventArgs(this, previousMode, currentMode);
            
            switch (currentMode)
            {
                case ExamMode.Starting:
                    ExamStarted?.Invoke(this, args);
                    break;
                case ExamMode.Queued:
                    ExamQueued?.Invoke(this, args);
                    break;
                case ExamMode.Finished:
                    ExamFinished?.Invoke(this, args);
                    break;
            }
        }

        public abstract void ShowExam();
        public abstract void ShowResults();

        public virtual void StartExam()
        {
            Mode = ExamMode.Starting;
        }

        public virtual void FinishExam()
        {
            Mode = ExamMode.Finished;
        }

        public virtual void QueueExam()
        {
            Mode = ExamMode.Queued;
        }

        public void AddQuestion(Question question, AnswerList answers)
        {
            // Set the answers to the question itself
            question.Answers = answers;
            Questions.Add(question);
            QuestionAnswerDictionary[question] = answers;
        }

        public void RemoveQuestion(Question question)
        {
            Questions.Remove(question);
            QuestionAnswerDictionary.Remove(question);
        }

        public virtual void TakeExam()
        {
            Console.WriteLine($"\n=== Taking {Type} Exam ===");
            StartExam();
            
            UserAnswers.Clear();
            
            for (int i = 0; i < Questions.Count; i++)
            {
                var question = Questions[i];
                var userAnswer = new UserAnswer(question);
                
                Console.WriteLine($"\nQuestion {i + 1}:");
                question.Show();
                
                // Get user input based on question type
                if (question is QuestionTF)
                {
                    GetTrueFalseAnswer(userAnswer);
                }
                else if (question is QuestionChooseOne)
                {
                    GetChooseOneAnswer(userAnswer);
                }
                else if (question is QuestionChooseAll)
                {
                    GetChooseAllAnswer(userAnswer);
                }
                
                // Calculate score
                if (QuestionAnswerDictionary.ContainsKey(question))
                {
                    userAnswer.CalculateScore(QuestionAnswerDictionary[question]);
                }
                
                UserAnswers.Add(userAnswer);
                Console.WriteLine();
            }
            
            FinishExam();
            ShowResults();
        }

        private void GetTrueFalseAnswer(UserAnswer userAnswer)
        {
            Console.Write("Enter your answer (1 for True, 2 for False): ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
                {
                    userAnswer.AddAnswer(choice);
                    break;
                }
                Console.Write("Invalid input. Please enter 1 for True or 2 for False: ");
            }
        }

        private void GetChooseOneAnswer(UserAnswer userAnswer)
        {
            var maxChoice = userAnswer.Question.Answers.Count;
            Console.Write($"Enter your answer (1-{maxChoice}): ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= maxChoice)
                {
                    userAnswer.AddAnswer(choice);
                    break;
                }
                Console.Write($"Invalid input. Please enter a number between 1 and {maxChoice}: ");
            }
        }

        private void GetChooseAllAnswer(UserAnswer userAnswer)
        {
            var maxChoice = userAnswer.Question.Answers.Count;
            Console.Write($"Enter your answers (e.g., 1,3,4 or just 2 for single answer): ");
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.Write("Please enter at least one answer: ");
                    continue;
                }
                
                var parts = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
                bool valid = true;
                
                foreach (var part in parts)
                {
                    if (int.TryParse(part.Trim(), out int choice) && choice >= 1 && choice <= maxChoice)
                    {
                        userAnswer.AddAnswer(choice);
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }
                
                if (valid)
                {
                    break;
                }
                
                Console.Write($"Invalid input. Please enter numbers between 1 and {maxChoice} separated by commas: ");
                userAnswer.ClearAnswers();
            }
        }

        public override string ToString()
        {
            return $"{Type} Exam - {Subject?.Name} (ID: {Id}, Questions: {NumOfQuestions}, Time: {Time:yyyy-MM-dd HH:mm})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Exam other)
            {
                return Id == other.Id && Type == other.Type && Subject?.Id == other.Subject?.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Type, Subject?.Id);
        }

        public virtual object Clone()
        {
            var clonedExam = (Exam)MemberwiseClone();
            clonedExam.Questions = new QuestionList($"exam_{Id}_questions_clone.txt");
            clonedExam.QuestionAnswerDictionary = new Dictionary<Question, AnswerList>();
            
            // Deep copy questions and answers
            foreach (var kvp in QuestionAnswerDictionary)
            {
                var clonedQuestion = (Question)kvp.Key.Clone();
                var clonedAnswers = new AnswerList(kvp.Value.Select(a => (Answer)a.Clone()));
                clonedExam.QuestionAnswerDictionary[clonedQuestion] = clonedAnswers;
                clonedExam.Questions.Add(clonedQuestion);
            }
            
            return clonedExam;
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return Time.CompareTo(other.Time);
        }
    }

    // Practice Exam - shows correct answers after completion
    public class PracticeExam : Exam
    {
        public PracticeExam(int id, DateTime time, int numOfQuestions, Subject subject) 
            : base(id, time, numOfQuestions, "Practice", subject)
        {
        }

        public PracticeExam() : base() { }

        public override void ShowExam()
        {
            Console.WriteLine($"=== {Type} Exam ===");
            Console.WriteLine($"Subject: {Subject?.Name}");
            Console.WriteLine($"Time: {Time:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}");
            Console.WriteLine($"Mode: {Mode}");
            Console.WriteLine("========================\n");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Questions[i].Show();
                Console.WriteLine();
            }
        }

        public override void ShowResults()
        {
            Console.WriteLine("=== PRACTICE EXAM RESULTS ===");
            Console.WriteLine($"Total Score: {UserAnswers.GetTotalScore()}/{UserAnswers.GetMaxPossibleScore()} ({UserAnswers.GetPercentage():F1}%)");
            Console.WriteLine($"Correct Answers: {UserAnswers.GetCorrectAnswersCount()}/{UserAnswers.GetTotalQuestionsCount()}");
            Console.WriteLine();
            
            for (int i = 0; i < Questions.Count; i++)
            {
                var question = Questions[i];
                var userAnswer = UserAnswers.GetAnswerForQuestion(question);
                var correctAnswers = QuestionAnswerDictionary[question];
                
                Console.WriteLine($"Question {i + 1}: {question.Body}");
                Console.WriteLine($"Your Answer: {userAnswer?.GetSelectedAnswersText(correctAnswers) ?? "No answer"}");
                Console.WriteLine($"Correct Answer: {userAnswer?.GetCorrectAnswersText(correctAnswers) ?? "N/A"}");
                Console.WriteLine($"Result: {(userAnswer?.IsCorrect == true ? "✓ CORRECT" : "✗ INCORRECT")} ({userAnswer?.Score ?? 0}/{question.Marks} points)");
                Console.WriteLine();
            }
        }
    }

    // Final Exam - only shows questions and answers, no correct answers revealed
    public class FinalExam : Exam
    {
        public FinalExam(int id, DateTime time, int numOfQuestions, Subject subject) 
            : base(id, time, numOfQuestions, "Final", subject)
        {
        }

        public FinalExam() : base() { }

        public override void ShowExam()
        {
            Console.WriteLine($"=== {Type} Exam ===");
            Console.WriteLine($"Subject: {Subject?.Name}");
            Console.WriteLine($"Time: {Time:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}");
            Console.WriteLine($"Mode: {Mode}");
            Console.WriteLine("========================\n");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                Questions[i].Show();
                Console.WriteLine();
            }
        }

        public override void ShowResults()
        {
            Console.WriteLine("=== FINAL EXAM RESULTS ===");
            Console.WriteLine($"Total Score: {UserAnswers.GetTotalScore()}/{UserAnswers.GetMaxPossibleScore()} ({UserAnswers.GetPercentage():F1}%)");
            Console.WriteLine($"Correct Answers: {UserAnswers.GetCorrectAnswersCount()}/{UserAnswers.GetTotalQuestionsCount()}");
            Console.WriteLine();
            
            for (int i = 0; i < Questions.Count; i++)
            {
                var question = Questions[i];
                var userAnswer = UserAnswers.GetAnswerForQuestion(question);
                var correctAnswers = QuestionAnswerDictionary[question];
                
                Console.WriteLine($"Question {i + 1}: {question.Body}");
                Console.WriteLine($"Your Answer: {userAnswer?.GetSelectedAnswersText(correctAnswers) ?? "No answer"}");
                Console.WriteLine($"Result: {(userAnswer?.IsCorrect == true ? "✓ CORRECT" : "✗ INCORRECT")} ({userAnswer?.Score ?? 0}/{question.Marks} points)");
                Console.WriteLine();
            }
            
            Console.WriteLine("Note: Correct answers are not shown for final exams.");
            Console.WriteLine("Your answers have been submitted for grading.");
        }
    }
}
