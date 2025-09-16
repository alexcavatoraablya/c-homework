namespace PropAndConstructor
{
    public class Person
    {
        private string _id = null!;
        private string _firstName = null!;
        private string _lastName = null!;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Phone { get; set; }

        //Визивається при створенні класу
        //Змінні набувають початково значенню
        //Конструктор по замовчуванню
        public Person()
        {
            //GUID - рандомна величина яка не повторюється
            _id = Guid.NewGuid().ToString();
        }

        //Конструктор з параметрами
        public Person(string lastName, string firstName, string phone): this()
        {
            _lastName = lastName;
            _firstName = firstName;
            Phone = phone;
        }

        //Повертає значення _Id
        public string Id { get { return _id; } }

        public void setFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public string getFirstName()
        {
            return _firstName;
        }

        public override string ToString()
        {
            return $"{_id} -- {_firstName} {_lastName} -> {Phone}";
        }
    }
}
