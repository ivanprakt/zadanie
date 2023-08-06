using Dr;
class Program
{
    static void Main()
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }
   private static bool MainMenu()
   {
        DrService Dr = new DrService();
        Console.Clear();
        Dr.CloseDr();
        Console.WriteLine("Выберите дейстивие \n " +
            "1) Добавить запись \n " +
            "2) Просмотреть весь список \n " +
            "3) Удалить запись \n " +
            "4) Поиск записи \n " +
            "5) Редактирование ФИО записи \n " +
            "6) Редактирование ДР записи \n " +
            "7) Exit \n " +
            "\r\nВведите номер: ");
        switch (Console.ReadLine())
        {
            case "1":
                Dr.Add();
                return NextStepMenu();
            case "2":
                Dr.Print();
                return NextStepMenu(); 
            case "3":
                Dr.Delete();
                return NextStepMenu();
            case "4":
                Dr.Find();
                return NextStepMenu();
            case "5":
                Dr.UpdateFio();
                return NextStepMenu();
            case "6":
                Dr.UpdateDr();
                return NextStepMenu();
            case "7":
                return false;
            default:
                return true;
        }
   }
    private static bool NextStepMenu() //убрать лишнее
    {
        Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
        Console.ReadKey();
        return true;
    }
}



