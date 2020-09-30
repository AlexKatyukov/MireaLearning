// Задание: на какой-нибудь сущности показать работу двух шаблонов проектирования: паттерна Итератор и паттерна Посетитель
// Катюков Александр Максимович, БСМО-02-20


using System;

namespace IIS_BSMO0220_lab3
{
	class Program
  {
    static void Main(string[] args)
    {
      Catalog catalog = new Catalog();
      Ringer ringer = new Ringer();
      ringer.CallPhone(catalog);
    }
  }

  class Ringer
  {
    public void CallPhone(Catalog catalog)
    {
      ITelIterator iterator = catalog.CreateNumerator();
      while (iterator.HasNext())
      {
        Phone phone = iterator.Next();
        Console.WriteLine(phone.Number);
      }
    }
  }

  interface ITelIterator
  {
    bool HasNext();
    Phone Next();
  }
  interface IPhoneNumerable
  {
    ITelIterator CreateNumerator();
    int Count { get; }
    Phone this[int index] { get; }
  }
  class Phone
  {
    public string Number { get; set; }
  }

  class Catalog : IPhoneNumerable
  {
    private Phone[] phones;
    public Catalog()
    {
      phones = new Phone[]
      {
            new Phone {Number="+71234567890"},
            new Phone {Number="+72345678901"},
            new Phone {Number="+73456789012"}
      };
    }
    public int Count
    {
      get { return phones.Length; }
    }

    public Phone this[int index]
    {
      get { return phones[index]; }
    }
    public ITelIterator CreateNumerator()
    {
      return new CatalogNumerator(this);
    }
  }
  class CatalogNumerator : ITelIterator
  {
    IPhoneNumerable aggregate;
    int index = 0;
    public CatalogNumerator(IPhoneNumerable a)
    {
      aggregate = a;
    }
    public bool HasNext()
    {
      return index < aggregate.Count;
    }

    public Phone Next()
    {
      return aggregate[index++];
    }
  }
}
