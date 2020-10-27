//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------


//Por ISP para no exigir a Recipe la responsabilidad de imprimir por pantalla.
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Cumple con SRP ya que solo tiene una razón para cambiar que es los datos de impresión.
    /// Cumple con expert ya que es el mejor responsable para realizar la impresión.
    /// </summary>
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            System.Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                System.Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}