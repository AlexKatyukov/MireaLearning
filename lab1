using System;

namespace BSMO0220_Katyukov_IIS_LR1
{
  /*
   *  БСМО-02-20 Катюков Александр
   *  
   *  ЗАДАНИЕ (что поставил преподаватель):
   *  Реализовать Шаблонный метод или метод Стратегия
   *  
   *  Будем реализовывать шаблонный метод
   *  
   *  ЗАДАЧА (что будем решать):
   *  Показать варианты технического обслуживание автомобиля через типовые операции
   */

  class Operations
  {
    public static void Operation1()
    {
      Console.WriteLine("Загоняем автомобиль в бокс");
    }

    public static void Operation2()
    {
      Console.WriteLine("Меняем масло");
    }

    public static void Operation3()
    {
      Console.WriteLine("Меняем тормозные диски");
    }

    public static void Operation4()
    {
      Console.WriteLine("Меняем топливный фильтр");
    }

    public static void Operation5()
    {
      Console.WriteLine("Выписываем акт и выдаём автомобиль");
    }
  }

  class TO1 : Operations
  {
      
    static void Main(string[] args)
    {
      Operation1();
      Operation2();
      Operation5();
    }
  }
  
  class TO2 : Operations
  {
      
    static void Main(string[] args)
    {
      Operation1();
      Operation2();
      Operation4();
      Operation5();
    }
  }
  
  class TO3 : Operations
  {
      
    static void Main(string[] args)
    {
      Operation1();
      Operation2();
      Operation3();
      Operation5();
    }
  }
  
  class TO4 : Operations
  {
      
    static void Main(string[] args)
    {
      Operation1();
      Operation2();
      Operation3();
      Operation4();
      Operation5();
    }
  }
}
