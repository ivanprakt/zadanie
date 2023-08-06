namespace Dr
{
    public class DrService
    {
        private readonly DrRepository _repository;
        public DrService()
        {
            _repository = new DrRepository();
        }
        public void Add()
        {
            Console.WriteLine("Введите ФИО и нажмите enter");
            string? fio = Console.ReadLine();
            Console.WriteLine("Введите дату др образец(гггг.мм.дд) и нажмите enter");
            string? data = Console.ReadLine();
            User user = new User { Fio = fio, Dr = Convert.ToDateTime(data) };
            _repository.Add(user);
            Console.WriteLine("Объекты успешно сохранены");
        }
        public void Print()
        {
            Console.WriteLine("Все др:");
            var users = _repository.Print();
            foreach (User u in users)
            {
                Console.WriteLine($"{u.Id}.{u.Fio}.{u.Dr}");
            }
        }
        public void Delete()
        {
           
            Console.WriteLine("Введите id записи которую хотите удалить затем нажмите Enter");
            string? number = Console.ReadLine();
            _repository.Delete(Convert.ToInt32(number));
           
        }
        public void CloseDr()
        {
           Console.WriteLine("Список ближайших др");
           var users = _repository.CloseDr();
           if (users != null)
           {
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Fio} - {u.Dr}");
                }
           }
        }
        public void Find()
        {
            Console.WriteLine("Введите id записи которую хотите найти затем нажмите Enter");
            string? number = Console.ReadLine();
            var user = _repository.FindbyId(Convert.ToInt32(number));
            if (user != null)
            {
                Console.WriteLine($"{user.Id}.{user.Fio}.{user.Dr}");
            }
        }
        public void UpdateFio()
        {
            Console.WriteLine("Введите id записи которую хотите отредактировать затем нажмите Enter");
            string? number = Console.ReadLine();
            var user = _repository.FindbyId(Convert.ToInt32(number));
            Console.WriteLine("Введите ФИО и нажмите enter");
            string? fio = Console.ReadLine();
            user.Fio = fio;
            _repository.UpdateFio(user);
        }
        public void UpdateDr()
        {
            Console.WriteLine("Введите id записи которую хотите отредактировать затем нажмите Enter");
            string? number = Console.ReadLine();
            var user = _repository.FindbyId(Convert.ToInt32(number));
            Console.WriteLine("Введите дату др образец(гггг.мм.дд) и нажмите enter");
            string? data = Console.ReadLine();
            user.Dr = Convert.ToDateTime(data);
            _repository.UpdateDr(user);
        }
    }
}
