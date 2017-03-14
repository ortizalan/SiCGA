///////////////////////////////////////////////////////////
//  JerarquiasController.cs
//  Implementation of the Class JerarquiasController
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:37
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using SiCGA.Clases;
namespace SiCGA.Clases.Controladores {
	/// <summary>
	/// Controlador para el Modelo Jerarquias
	/// </summary>
	public class JerarquiasController : Metodos {

		public JerarquiasController(){

		}

		~JerarquiasController(){

		}

		/// <summary>
		/// Actualizar Cat�logo Jerarqu�as
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto del Tipo Jerarqu�as</param>
		public override bool ActualizarRegistro(object o){

			return false;
		}

		/// <summary>
		/// Consultar un Registro
		/// </summary>
		/// <returns>Boleano</returns>
		/// <param name="o">Objeto del Tipo Jerarqu�as</param>
		public override bool ConsultarRegistro(object o){

			return false;
		}

		public override bool ConsultarRegistros(){

			return false;
		}

		/// 
		/// <param name="o"></param>
		public override bool IngresarRegisto(object o){

			return false;
		}

	}//end JerarquiasController

}//end namespace Controladores