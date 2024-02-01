
    public class MathAssignment : Assignment
    {

        private string __textbookSection;
        private string __problem;
        public MathAssignment(string studentName, string topic, string textbookSection, string problems)
            : base(studentName, topic)

        {
            

            __textbookSection = textbookSection;
            __problem = problems;

        }


        public string GetHomeworkList(){

            return $" Section: {__textbookSection} Problems {__problem}";

        }
    }