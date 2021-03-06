///////////////////////////////////////////////////////////
//  SubFondosModel.cs
//  Implementation of the Class SubFondosModel
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:19:00
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using SADI.Clases.Modelos;
namespace SADI.Clases.Modelos {
	/// <summary>
	/// Modelo de la Tabla SubFondos
	/// </summary>
	public class SubFondosModel {

		private int _id;
		private string _subfondo;
		private FondosModel _fondo;

		public SubFondosModel(){

		}

		/// 
		/// <param name="id"></param>
		/// <param name="subf"></param>
		/// <param name="fondo"></param>
		public SubFondosModel(int id, string subf, FondosModel fondo){

		}

		~SubFondosModel(){

		}

		public int Id{
			get;
			set;
		}

		public string SubFondo{
			get;
			set;
		}

		public FondosModel Fondo{
			get;
			set;
		}

	}//end SubFondosModel

}//end namespace Modelos