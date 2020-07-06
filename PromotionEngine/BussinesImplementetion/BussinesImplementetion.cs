using BussinesServices;
using FactoryImplementation;
using System;
using System.Linq;

namespace BussinesImplementetion
{
    public class BussinesImplementetions
    {
        static bool istrue = false;
        public static int CalculateProdCosts(ProductInput _productinput)
        {
            
            Factory factory = new Factory();
            var _currProd = factory.ProdList().FirstOrDefault(p => p.Name == _productinput.Name);
            var totalCost = 0;
            switch (_productinput.Name)
            {
                case "A":
                    if (_productinput.No_Prod >= 3)
                    {
                        if (_productinput.No_Prod == 3)
                        {
                            totalCost = 130;
                        }
                        else
                        {
                            var _prodSets = _productinput.No_Prod / 3;
                            var _indprod = _productinput.No_Prod % 3;
                            totalCost = (_prodSets * 130 + _indprod * _currProd.Cost);
                        }
                    }
                    else
                    {
                        totalCost = _currProd.Cost * _productinput.No_Prod;
                    }
                    break;
                case "B":
                    if (_productinput.No_Prod >= 2)
                    {
                        if (_productinput.No_Prod == 2)
                        {
                            totalCost = 45;
                        }
                        else
                        {
                            var _prodSets = _productinput.No_Prod / 2;
                            var _indprod = _productinput.No_Prod % 2;
                            totalCost = (_prodSets * 45 + _indprod * _currProd.Cost);
                        }
                    }
                    else
                    {
                        totalCost = _currProd.Cost * _productinput.No_Prod;
                    }
                    break;
                case "C":
                    istrue = true;
                    totalCost = _currProd.Cost * _productinput.No_Prod;
                    break;
                case "D":
                    if (istrue)
                    {
                        totalCost = 30;
                    }
                    else
                    {
                        totalCost = _currProd.Cost * _productinput.No_Prod;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid promotion");
                    break;
            }
            return totalCost;
        }
    }
}
