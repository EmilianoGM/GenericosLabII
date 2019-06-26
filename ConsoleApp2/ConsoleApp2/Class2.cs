using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public class Algo
  {
    int numero;
    string letra;
    public Algo(int numero, string c)
    {
      this.numero = numero;
      this.letra = c;
    }
    public static bool operator ==(Algo algoUno, Algo algoDos)
    {
      if(algoUno.letra == algoDos.letra)
      {
        return true;
      }
      return false;
    }

    public static explicit operator string(Algo c)
    {
      return c.letra;
    }

    public static bool operator !=(Algo algoUno, Algo algoDos)
    {
      return !(algoUno == algoDos);
    }
  }
  public class Producto
  {
    public string nombre;
    public Producto(string nombre)
    {
      this.nombre = nombre;
    }
  }

  public class ProdImpuesto : Producto
  {
    public float impuesto;
    public ProdImpuesto(string nombre, float impuesto) : base(nombre)
    {
      this.impuesto = impuesto;
    }
  }

  public class ProdExport : ProdImpuesto
  {
    public string pais;
    public ProdExport(ProdImpuesto prodImpuesto, string pais) : base(prodImpuesto.nombre, prodImpuesto.impuesto)
    {
      this.pais = pais;
    }
  }

  public class ProdVendido : ProdExport
  {
    public string origenCliente;
    public ProdVendido(ProdExport prodExport, string origenCliente) : base((ProdImpuesto)prodExport, prodExport.pais)
    {
      this.origenCliente = origenCliente;
    }
  }
}
