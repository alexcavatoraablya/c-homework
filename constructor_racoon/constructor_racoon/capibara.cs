using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_racoon
{
    internal class capibara
    {
        private string _id = null!;
        private string _name = null!;
        private string _color = null!;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string color { get; set; }

        //Визивається при створенні класу
        //Змінні набувають початково значенню
        //Конструктор по замовчуванню
        public capibara()
        {
            //GUID - рандомна величина яка не повторюється
            _id = Guid.NewGuid().ToString();
        }

        //Конструктор з параметрами
        public capibara(string name, string color) : this()
        {
            _name = name;
            _color = color;
        }

        //Повертає значення _Id
        public string Id { get { return _id; } }

        public void setName(string name)
        {
            _name = name;
        }
        public string getName()
        {
            return _name;
        }

        public override string ToString()
        {
            return $"{_id} -- {_name} -> {_color}";
        }
    }
}
