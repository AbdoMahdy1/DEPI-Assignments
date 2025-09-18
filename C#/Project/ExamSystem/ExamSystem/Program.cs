using System;
using System.Collections.Generic;

namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Examination System ===");
            Console.WriteLine();

            // Create subjects
            var mathSubject = new Subject(1, "Mathematics", "MATH101", "Basic Mathematics", 3, "Mathematics Department");
            var csSubject = new Subject(2, "Computer Science", "CS101", "Introduction to Computer Science", 4, "Computer Science Department");

            // Create students
            var student1 = new Student(1, "Abdo Mahdi", "john.doe@university.edu");
            var student2 = new Student(2, "Mohamed Ali", "jane.smith@university.edu");

            // Enroll students in subjects
            student1.EnrollInSubject(mathSubject);
            student1.EnrollInSubject(csSubject);
            student2.EnrollInSubject(mathSubject);

            // Create practice exam
            var practiceExam = new PracticeExam(1, DateTime.Now.AddHours(1), 8, mathSubject);
            
            // Create final exam
            var finalExam = new FinalExam(2, DateTime.Now.AddDays(1), 12, csSubject);

            // Register students for exams
            student1.RegisterForExam(practiceExam);
            student1.RegisterForExam(finalExam);
            student2.RegisterForExam(practiceExam);

            // Create sample questions and answers for practice exam
            CreateSampleQuestions(practiceExam);
            
            // Create sample questions and answers for final exam
            CreateSampleQuestions(finalExam);

            // Main menu
            while (true)
            {
                Console.WriteLine("\n=== Main Menu ===");
                Console.WriteLine("1. Take Practice Exam");
                Console.WriteLine("2. Take Final Exam");
                Console.WriteLine("3. Show Exam Details");
                Console.WriteLine("4. View Exam Results (if taken)");
                Console.WriteLine("5. Simulate Exam Mode Changes");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option (1-6): ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TakeExam(practiceExam);
                        break;
                    case "2":
                        TakeExam(finalExam);
                        break;
                    case "3":
                        ShowExamDetails(practiceExam, finalExam);
                        break;
                    case "4":
                        ViewExamResults(practiceExam, finalExam);
                        break;
                    case "5":
                        SimulateExamModeChanges(practiceExam, finalExam);
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreateSampleQuestions(Exam exam)
        {
            if (exam is PracticeExam)
            {
                // True/False Question
                var tfQuestion = new QuestionTF(1, "True/False", "2 + 2 = 4", 2);
                var tfAnswers = new AnswerList();
                tfAnswers.Add(new Answer(1, "True", true));
                tfAnswers.Add(new Answer(2, "False", false));
                exam.AddQuestion(tfQuestion, tfAnswers);

                // Choose One Question
                var coQuestion = new QuestionChooseOne(2, "Multiple Choice", "What is the capital of France?", 3);
                var coAnswers = new AnswerList();
                coAnswers.Add(new Answer(1, "London", false));
                coAnswers.Add(new Answer(2, "Paris", true));
                coAnswers.Add(new Answer(3, "Berlin", false));
                coAnswers.Add(new Answer(4, "Madrid", false));
                exam.AddQuestion(coQuestion, coAnswers);

                // Choose All Question
                var caQuestion = new QuestionChooseAll(3, "Multiple Select", "Which of the following are programming languages?", 4);
                var caAnswers = new AnswerList();
                caAnswers.Add(new Answer(1, "C#", true));
                caAnswers.Add(new Answer(2, "Java", true));
                caAnswers.Add(new Answer(3, "HTML", false));
                caAnswers.Add(new Answer(4, "Python", true));
                exam.AddQuestion(caQuestion, caAnswers);

                // Additional True/False Question
                var tfQuestion2 = new QuestionTF(4, "True/False", "The Earth revolves around the Sun", 2);
                var tfAnswers2 = new AnswerList();
                tfAnswers2.Add(new Answer(1, "True", true));
                tfAnswers2.Add(new Answer(2, "False", false));
                exam.AddQuestion(tfQuestion2, tfAnswers2);

                // Additional Choose One Question
                var coQuestion2 = new QuestionChooseOne(5, "Multiple Choice", "What is the largest planet in our solar system?", 3);
                var coAnswers2 = new AnswerList();
                coAnswers2.Add(new Answer(1, "Earth", false));
                coAnswers2.Add(new Answer(2, "Jupiter", true));
                coAnswers2.Add(new Answer(3, "Saturn", false));
                coAnswers2.Add(new Answer(4, "Mars", false));
                exam.AddQuestion(coQuestion2, coAnswers2);

                // Additional Choose All Question
                var caQuestion2 = new QuestionChooseAll(6, "Multiple Select", "Which of the following are primary colors?", 4);
                var caAnswers2 = new AnswerList();
                caAnswers2.Add(new Answer(1, "Red", true));
                caAnswers2.Add(new Answer(2, "Blue", true));
                caAnswers2.Add(new Answer(3, "Green", true));
                caAnswers2.Add(new Answer(4, "Yellow", false));
                exam.AddQuestion(caQuestion2, caAnswers2);

                // Additional True/False Question
                var tfQuestion3 = new QuestionTF(7, "True/False", "Water boils at 100°C at sea level", 2);
                var tfAnswers3 = new AnswerList();
                tfAnswers3.Add(new Answer(1, "True", true));
                tfAnswers3.Add(new Answer(2, "False", false));
                exam.AddQuestion(tfQuestion3, tfAnswers3);

                // Additional Choose One Question
                var coQuestion3 = new QuestionChooseOne(8, "Multiple Choice", "Who wrote 'Romeo and Juliet'?", 3);
                var coAnswers3 = new AnswerList();
                coAnswers3.Add(new Answer(1, "Charles Dickens", false));
                coAnswers3.Add(new Answer(2, "William Shakespeare", true));
                coAnswers3.Add(new Answer(3, "Mark Twain", false));
                coAnswers3.Add(new Answer(4, "Jane Austen", false));
                exam.AddQuestion(coQuestion3, coAnswers3);
            }
            else if (exam is FinalExam)
            {
                // True/False Question
                var tfQuestion = new QuestionTF(1, "True/False", "C# is a compiled language", 2);
                var tfAnswers = new AnswerList();
                tfAnswers.Add(new Answer(1, "True", true));
                tfAnswers.Add(new Answer(2, "False", false));
                exam.AddQuestion(tfQuestion, tfAnswers);

                // Choose One Question
                var coQuestion = new QuestionChooseOne(2, "Multiple Choice", "What does OOP stand for?", 3);
                var coAnswers = new AnswerList();
                coAnswers.Add(new Answer(1, "Object-Oriented Programming", true));
                coAnswers.Add(new Answer(2, "Object-Oriented Process", false));
                coAnswers.Add(new Answer(3, "Object-Oriented Protocol", false));
                coAnswers.Add(new Answer(4, "Object-Oriented Pattern", false));
                exam.AddQuestion(coQuestion, coAnswers);

                // Choose All Question
                var caQuestion = new QuestionChooseAll(3, "Multiple Select", "Which are valid C# access modifiers?", 4);
                var caAnswers = new AnswerList();
                caAnswers.Add(new Answer(1, "public", true));
                caAnswers.Add(new Answer(2, "private", true));
                caAnswers.Add(new Answer(3, "protected", true));
                caAnswers.Add(new Answer(4, "internal", true));
                exam.AddQuestion(caQuestion, caAnswers);

                // Additional questions for final exam
                var tfQuestion2 = new QuestionTF(4, "True/False", "Interfaces can have method implementations in C#", 2);
                var tfAnswers2 = new AnswerList();
                tfAnswers2.Add(new Answer(1, "True", false));
                tfAnswers2.Add(new Answer(2, "False", true));
                exam.AddQuestion(tfQuestion2, tfAnswers2);

                var coQuestion2 = new QuestionChooseOne(5, "Multiple Choice", "What is the base class for all classes in C#?", 3);
                var coAnswers2 = new AnswerList();
                coAnswers2.Add(new Answer(1, "System", false));
                coAnswers2.Add(new Answer(2, "Object", true));
                coAnswers2.Add(new Answer(3, "Base", false));
                coAnswers2.Add(new Answer(4, "Class", false));
                exam.AddQuestion(coQuestion2, coAnswers2);

                // Additional True/False Question
                var tfQuestion3 = new QuestionTF(6, "True/False", "C# supports multiple inheritance for classes", 2);
                var tfAnswers3 = new AnswerList();
                tfAnswers3.Add(new Answer(1, "True", false));
                tfAnswers3.Add(new Answer(2, "False", true));
                exam.AddQuestion(tfQuestion3, tfAnswers3);

                // Additional Choose One Question
                var coQuestion3 = new QuestionChooseOne(7, "Multiple Choice", "What keyword is used to create a new instance of a class?", 3);
                var coAnswers3 = new AnswerList();
                coAnswers3.Add(new Answer(1, "new", true));
                coAnswers3.Add(new Answer(2, "create", false));
                coAnswers3.Add(new Answer(3, "instance", false));
                coAnswers3.Add(new Answer(4, "make", false));
                exam.AddQuestion(coQuestion3, coAnswers3);

                // Additional Choose All Question
                var caQuestion2 = new QuestionChooseAll(8, "Multiple Select", "Which of the following are value types in C#?", 4);
                var caAnswers2 = new AnswerList();
                caAnswers2.Add(new Answer(1, "int", true));
                caAnswers2.Add(new Answer(2, "string", false));
                caAnswers2.Add(new Answer(3, "bool", true));
                caAnswers2.Add(new Answer(4, "double", true));
                exam.AddQuestion(caQuestion2, caAnswers2);

                // Additional True/False Question
                var tfQuestion4 = new QuestionTF(9, "True/False", "LINQ can only be used with databases", 2);
                var tfAnswers4 = new AnswerList();
                tfAnswers4.Add(new Answer(1, "True", false));
                tfAnswers4.Add(new Answer(2, "False", true));
                exam.AddQuestion(tfQuestion4, tfAnswers4);

                // Additional Choose One Question
                var coQuestion4 = new QuestionChooseOne(10, "Multiple Choice", "What is the purpose of the 'using' statement in C#?", 3);
                var coAnswers4 = new AnswerList();
                coAnswers4.Add(new Answer(1, "To import namespaces", true));
                coAnswers4.Add(new Answer(2, "To create loops", false));
                coAnswers4.Add(new Answer(3, "To define variables", false));
                coAnswers4.Add(new Answer(4, "To handle exceptions", false));
                exam.AddQuestion(coQuestion4, coAnswers4);

                // Additional Choose All Question
                var caQuestion3 = new QuestionChooseAll(11, "Multiple Select", "Which of the following are valid loop constructs in C#?", 4);
                var caAnswers3 = new AnswerList();
                caAnswers3.Add(new Answer(1, "for", true));
                caAnswers3.Add(new Answer(2, "while", true));
                caAnswers3.Add(new Answer(3, "foreach", true));
                caAnswers3.Add(new Answer(4, "do-while", true));
                exam.AddQuestion(caQuestion3, caAnswers3);

                // Additional True/False Question
                var tfQuestion5 = new QuestionTF(12, "True/False", "Properties in C# can have both get and set accessors", 2);
                var tfAnswers5 = new AnswerList();
                tfAnswers5.Add(new Answer(1, "True", true));
                tfAnswers5.Add(new Answer(2, "False", false));
                exam.AddQuestion(tfQuestion5, tfAnswers5);
            }
        }

        static void TakeExam(Exam exam)
        {
            exam.TakeExam();
        }

        static void ShowExamDetails(Exam practiceExam, Exam finalExam)
        {
            Console.WriteLine("\n=== Exam Details ===");
            Console.WriteLine($"Practice Exam: {practiceExam}");
            Console.WriteLine($"Final Exam: {finalExam}");
            
            Console.WriteLine("\nPractice Exam Questions:");
            for (int i = 0; i < practiceExam.Questions.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {practiceExam.Questions[i].GetQuestionType()}: {practiceExam.Questions[i].Body}");
            }
            
            Console.WriteLine("\nFinal Exam Questions:");
            for (int i = 0; i < finalExam.Questions.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {finalExam.Questions[i].GetQuestionType()}: {finalExam.Questions[i].Body}");
            }
        }

        static void ViewExamResults(Exam practiceExam, Exam finalExam)
        {
            Console.WriteLine("\n=== View Exam Results ===");
            Console.WriteLine("1. Practice Exam Results");
            Console.WriteLine("2. Final Exam Results");
            Console.Write("Select exam (1-2): ");
            
            var choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    if (practiceExam.UserAnswers.Count > 0)
                    {
                        practiceExam.ShowResults();
                    }
                    else
                    {
                        Console.WriteLine("Practice exam has not been taken yet.");
                    }
                    break;
                case "2":
                    if (finalExam.UserAnswers.Count > 0)
                    {
                        finalExam.ShowResults();
                    }
                    else
                    {
                        Console.WriteLine("Final exam has not been taken yet.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        static void SimulateExamModeChanges(Exam practiceExam, Exam finalExam)
        {
            Console.WriteLine("\n=== Simulating Exam Mode Changes ===");
            
            Console.WriteLine("Changing Practice Exam to Starting mode...");
            practiceExam.StartExam();
            
            Console.WriteLine("Changing Practice Exam to Finished mode...");
            practiceExam.FinishExam();
            
            Console.WriteLine("Changing Final Exam to Starting mode...");
            finalExam.StartExam();
            
            Console.WriteLine("Changing Final Exam to Queued mode...");
            finalExam.QueueExam();
        }
    }
}
