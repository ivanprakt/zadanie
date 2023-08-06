namespace Dr
{
    public class DrRepository
    {
        private readonly ApplicationContext _db;
        public DrRepository()
        {
            _db = new ApplicationContext();
        }
        public void Add(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public List<User> Print()
        {
            return _db.Users.ToList();
        }
        public void Delete(int number)
        {
            User? user = _db.Users.FirstOrDefault(u => u.Id == number);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
        }
        public User FindbyId(int number)
        {
           return _db.Users.FirstOrDefault(u => u.Id == number);
        }
        public List<User> CloseDr()
        {
             return _db.Users.Where(x => x.Dr.DayOfYear > DateTime.Now.DayOfYear && x.Dr.DayOfYear < DateTime.Now.DayOfYear + 15).ToList();
        }
        public void UpdateFio(User user)
        {
            if (user != null)
            {
                _db.Users.Update(user);
                _db.SaveChanges();
            }
        }
        public void UpdateDr(User user)
        {
            if (user != null)
            {
                _db.Users.Update(user);
                _db.SaveChanges();
            }
        }
    }
}
