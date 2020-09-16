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

  public class StandartTO
  {
    public virtual void StartTO()
    {
      Take();
      ChangeOil();
      ChangeBreaks();
      ChangeFilter();
      Billing();
    }

    public virtual void Take()
    {
      Console.WriteLine("Загоняем автомобиль в бокс");
    }

    public virtual void ChangeOil()
    {
      Console.WriteLine("Меняем масло");
    }

    public virtual void ChangeBreaks()
    {
      Console.WriteLine("Меняем тормозные диски");
    }

    public virtual void ChangeFilter()
    {
      Console.WriteLine("Меняем топливный фильтр");
    }

    public virtual void Billing()
    {
      Console.WriteLine("Выписываем акт и выдаём автомобиль");
    }
  }

  public class MotoTO : StandartTO
  {


    public override void Take()
    {
      Console.WriteLine("Загоняем мотоцикл в бокс");
    }
    public override void ChangeBreaks()
    {
      Console.WriteLine("Меняем тормозные колодки");
    }

    public override void Billing()
    {
      Console.WriteLine("Выписываем акт и выдаём мотоцикл");
    }
  }

  public class GruzovikTO : StandartTO
  {


    public override void ChangeOil()
    {
      Console.WriteLine("Матерясь, меняем масло");
    }
    public override void ChangeBreaks()
    {
      Console.WriteLine("Матерясь, меняем тормозные колодки");
    }

    public override void ChangeFilter()
    {
      Console.WriteLine("Матерясь, меняем топливный фильтр");
    }
  }

  class Program
  {
      
    static void Main(string[] args)
    {
      var moto = new MotoTO();

      var gruz = new GruzovikTO();

      moto.StartTO();
      
      Console.WriteLine();

      gruz.StartTO();
    }
  }
}
