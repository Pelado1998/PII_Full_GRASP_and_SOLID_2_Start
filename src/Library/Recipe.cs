//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    ///Cumple con Expert porque es el único responsable de conocer los datos de la receta
    ///Cumple con SRP porque tiene una única razón de cambio que es cambiar los datos de la receta
    ///Cumple con composite ya que toma objetos de varios tipos y compone uno nuevo en forma de arbol
    /// </summary>
    public class Recipe
    {
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
    }
}