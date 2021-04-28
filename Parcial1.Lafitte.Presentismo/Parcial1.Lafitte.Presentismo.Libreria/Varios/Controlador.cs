using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public class Controlador
    {
       public int ValidaNumerico(string s)
       {
           int i;
           if (int.TryParse(s, out i))
           {
               
                return i;
           }
           else
           {
               throw new ValorNoNumerico();
           }
       }
        public string IngresoValido(string s, out string s1)
        {
            int i;
            if (s == "X")
            {
                if (Convert.ToInt32(s) == 1 || Convert.ToInt32(s) == 2)
                {
                s1 = s;
                return s1;

                }
                else
                {
                    throw new OperacionInvalida();
                }
            }
            else if (int.TryParse(s, out i))
            {
                s1 = s;
                return s1;
            }
            else
            {
                throw new ValorNoNumerico();
            }
        }
    }
    //    public List<object> _list = new List<object>();

    //    private bool flag=true;
    //    public bool Flag { get => flag; set => flag = value; }

    //    public string AgregarObj(Object obj)
    //    {

    //        Object B = _list.FirstOrDefault(o => o.dato == obj.dato);
    //        if (B.dato != null)
    //        {
    //            _list.Add(obj);
    //             return $"Registro {1} agregado correctamente.";
    //        }
    //        else
    //        {
    //             throw new InvalidOperationException();
    //        }
    //    }
    //    public string EliminarObj(Object obj)
    //    {
    //        if (obj != null)
    //            _list.Remove(obj);
    //            return $"Registro {1} eliminado correctamente.";
    //        else
    //            throw new InvalidOperationException();
    //    }
    //    public double ValidaDouble(string s)
    //    {
    //        double d;
    //        if (double.TryParse(s, out d))
    //        {
    //            return d;
    //        }
    //        else
    //        {
    //            throw new ValorNoNumerico();
    //        }
    //    }
    //    public void ValidaExistencia(int i)
    //    {
    //        object obj;
    //        if (_list != null)
    //        {

    //        try
    //        {
    //            obj = _list.FirstOrDefault(o => o.dato == i);
    //            if (aux.Codigo != null)
    //            {
    //                throw new Exception();

    //            }
    //        }
    //        catch (NullReferenceException)
    //        {

    //        }
    //        }
    //    }
    //    public string Listar()
    //    {
    //        string msg = "";
    //        foreach (Object obj in _list)
    //        {
    //            msg += (obj.ToString() + Environment.NewLine);
    //        }
    //        return msg;
    //    }
    //    public string ToString()
    //    {
    //        return $"{this.Dato}";
    //    }
    //    public override bool Equals(object obj)
    //    {
    // if (obj==null)
    // {
    // return false;
    // }            
    // Object A = (Object)obj;
    //        if (A.dato == this._dato)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}
}
