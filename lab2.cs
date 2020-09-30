using System;
using System.Collections;
using System.Collections.Generic;

namespace IIS_BSMO0220_KatyukovAM_lab2_v2
{
  class Program
  {
    static void Main(string[] args)
    {
      var structure = new Shop();
      structure.Add(new Male { Name = "Максим", Number = "+71234567890" });
      structure.Add(new Female { Name = "Надежда", Number = "+72345678901" });
      structure.Add(new Male { Name = "Игорь", Number = "+723456789012" });
      structure.Accept(new NewShopVisitor());
      structure.Accept(new CouponVisitor());
    }
  }

  interface IVisitor
  {
    void VisitMaleAcc(Male acc);
    void VisitFemaleAcc(Female acc);
  }

  class NewShopVisitor : IVisitor
  {
    public void VisitMaleAcc(Male acc)
    {
      Console.WriteLine("Приглашаем вас, господин " + acc.Name + " в новый магазин");
    }

    public void VisitFemaleAcc(Female acc)
    {
      Console.WriteLine("Приглашаем вас, госпожа " + acc.Name + " в новый магазин");
    }
  }

  class CouponVisitor : IVisitor
  {
    public void VisitMaleAcc(Male acc)
    {
      Console.WriteLine("Дарим вам, господин " + acc.Name + " скидку на новую покупку");
    }

    public void VisitFemaleAcc(Female acc)
    {
      Console.WriteLine("Дарим вам, госпожа " + acc.Name + " скидку на новую покупку");
    }
  }

  class Shop
  {
    List<IAccount> accounts = new List<IAccount>();
    public void Add(IAccount acc)
    {
      accounts.Add(acc);
    }
    public void Remove(IAccount acc)
    {
      accounts.Remove(acc);
    }
    public void Accept(IVisitor visitor)
    {
      foreach (IAccount acc in accounts)
        acc.Accept(visitor);
    }
  }

  interface IAccount
  {
    void Accept(IVisitor visitor);
  }

  class Male : IAccount
  {
    public string Name { get; set; }
    public string Number { get; set; }

    public void Accept(IVisitor visitor)
    {
      visitor.VisitMaleAcc(this);
    }
  }

  class Female : IAccount
  {
    public string Name { get; set; }
    public string Number { get; set; }

    public void Accept(IVisitor visitor)
    {
      visitor.VisitFemaleAcc(this);
    }
  }
}
