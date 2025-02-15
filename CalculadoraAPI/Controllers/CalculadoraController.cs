using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculadoraAPI.Controllers
{
    public class CalculadoraController : Controller
    {
        //reference code:
        //https://github.com/U-C-S/Basic-Calculator

        public static float ExecutaCalculo(float valorUm, string operador, float valorDois)
        {
            float resultado;

            switch (operador)
            {
                case "+":
                    resultado = valorUm + valorDois; 
                    break;

                case "-":            
                    resultado = valorUm - valorDois; 
                    break;

                case "*":            
                    resultado = valorUm * valorDois; 
                    break;

                case "/":            
                    resultado = valorUm / valorDois; 
                    break;

                default: 
                    throw new Exception("Operador inválido");
            }

            return resultado;
        }
    }
}
