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

  public class AbstractOperations
  {
    public void Go()
    {
      Operation1();
      Operation2();
      Operation3();
      Operation4();
      Operation5();
    }

    public void Operation1()
    {
      Console.WriteLine("Загоняем автомобиль в бокс");
    }

    public void Operation2()
    {
      Console.WriteLine("Меняем масло");
    }

    public void Operation3()
    {
      Console.WriteLine("Меняем тормозные диски");
    }

    public void Operation4()
    {
      Console.WriteLine("Меняем топливный фильтр");
    }

    public void Operation5()
    {
      Console.WriteLine("Выписываем акт и выдаём автомобиль");
    }
  }

  public class MotoOperations : AbstractOperations
  {
    public void Operation1()
    {
      Console.WriteLine("Загоняем мотоцикл в бокс");
    }
    public void Operation3()
    {
      Console.WriteLine("Меняем тормозные колодки");
    }

    public void Operation4()
    {
      Console.WriteLine("Меняем систему зажигания");
    }

    public void Operation5()
    {
      Console.WriteLine("Выписываем акт и выдаём мотоцикл");
    }
  }

  public class GruzovikOperations : AbstractOperations
  {
    public void Operation2()
    {
      Console.WriteLine("Матерясь, меняем масло");
    }
    public void Operation3()
    {
      Console.WriteLine("Матерясь, меняем тормозные колодки");
    }

    public void Operation4()
    {
      Console.WriteLine("Матерясь, меняем топливный фильтр");
    }
  }

  class Program
  {
      
    static void Main(string[] args)
    {
      var moto = new MotoOperations();

      var gruz = new GruzovikOperations();

      moto.Go();
      
      Console.WriteLine();

      gruz.Go();


    }
  }
}
