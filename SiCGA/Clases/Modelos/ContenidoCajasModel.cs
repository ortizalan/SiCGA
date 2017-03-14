///////////////////////////////////////////////////////////
//  ContenidoCajasModel.cs
//  Implementation of the Class ContenidoCajasModel
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:32
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using SiCGA.Clases.Modelos;
namespace SiCGA.Clases.Modelos {
	public class ContenidoCajasModel {

		/// <summary>
		/// Propiedad Identificadora del Contenido de las Cajas
		/// </summary>
		private int _id;
		/// <summary>
		/// Propiedad identificadora de la Caja
		/// </summary>
		private CajasModel _caja;
		/// <summary>
		/// Propiedad identificadora dela Serie Documental del contenido
		/// </summary>
		private RegistrosModel _seriedoctal;

		public ContenidoCajasModel(){

		}

		~ContenidoCajasModel(){

		}

		/// <summary>
		/// Acceso a la Propiedad Identificadora
		/// </summary>
		public int Id{
            get { return _id; }
            set { _id = value; }
		}

		/// <summary>
		/// Acceso a la Propiedad Identificdor de Caja
		/// </summary>
		public CajasModel Caja{
            get { return _caja; }
            set { _caja = value; }
		}

		/// <summary>
		/// Acceso ala Propiedad Serie Documental del Contenido de la Caja
		/// </summary>
		public RegistrosModel SerieDoctal{
            get { return _seriedoctal; }
            set { _seriedoctal = value; }
		}

	}//end ContenidoCajasModel

}//end namespace Modelos