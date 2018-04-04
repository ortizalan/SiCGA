///////////////////////////////////////////////////////////
//  DigitalizacionesController.cs
//  Implementation of the Class DigitalizacionesController
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:33
//  Original author: Ing. Alan Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SADI.Clases.Modelos;



using SADI.Clases;
namespace SADI.Clases.Controladores
{
    /// <summary>
    /// Controlador para el Modelo Digitalizaciones
    /// </summary>
    public class DigitalizacionesController : Metodos
    {
        /// <summary>
        /// Constructor de Clase
        /// </summary>
		public DigitalizacionesController()
        {

        }
        /// <summary>
        /// Destructor
        /// </summary>
		~DigitalizacionesController()
        {

        }

        /// <summary>
        /// M�todo Para Consultar un Registro
        /// </summary>
        /// <returns>Boleano</returns>
        /// <param name="o">Objeto del Tipo class</param>
        public override bool ConsultarRegistro(Object o)
        {

            if (o.GetType() == typeof(DigitalizacionesModel))// Verificar si el objeto es del tipo DigitalizacionesModel
            {
                var di = (DigitalizacionesModel)o; // Castear variable "di" al tipo Digitalizaci�n Model

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear una lista de par�metros
                        lista.Add(new Parametros(@"opc", "4"));// Mandarle la opci�n al procedimiento
                        lista.Add(new Parametros(@"id", di.Id.ToString()));// Identificador del Registro
                        lista.Add(new Parametros(@"seriedoc", string.Empty));// VAc�o
                        lista.Add(new Parametros(@"docu", string.Empty));// Vacio
                        lista.Add(new Parametros(@"nomdocu", string.Empty));//Vac�o
                        lista.Add(new Parametros(@"exte", string.Empty));//Vac�o
                        lista.Add(new Parametros(@"filesize", string.Empty));//Vac�o
                        lista.Add(new Parametros(@"folio", string.Empty));// Vac�o

                        string proce = "sp_digitalizacion_crud";// Indicarle el Procedimiento

                        if (ConsultarProcedimiento(proce, lista))// Intentar Consultar el Procedimiento
                        { return true; }// Consulta Exitosa, Consulte Tabla
                        else
                        { return false; }// COnsulta NO Exitosa, Consulte Error
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();// Guardar el Error
                        return false;// Indicar que exoste el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Intento de Conexi�n Fallido, Consultar Error
            }
            else
            { return false; }// No es del tipo DigitalizacionesModel
        }

        /// <summary>
        /// M�todo Para Actualizar los Registros
        /// </summary>
        /// <returns>Boleano</returns>
        /// <param name="o">Objeto del Tipo class</param>
        public override bool ActualizarRegistro(Object o)
        {

            if (o.GetType() == typeof(DigitalizacionesModel))// Verificar si el objeto es del tipo DigitalizacionesModel
            {
                var di = (DigitalizacionesModel)o; // Castear variable "di" al tipo Digitalizaci�n Model

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear una lista de par�metros
                        lista.Add(new Parametros(@"opc", "3"));// Mandarle la opci�n al procedimiento
                        lista.Add(new Parametros(@"id", di.Id.ToString()));// Identificador del Registro
                        lista.Add(new Parametros(@"seriedoc", di.SDoctal.SerieDoctal));// Serie Documetal
                        lista.Add(new Parametros(@"docu", di.Documento.ToString()));// Documento Digitalizado
                        lista.Add(new Parametros(@"nomdocu", di.NombreDoc));//Nombre del Documento
                        lista.Add(new Parametros(@"exte", di.Extension));//Extensi�n, tipo de documento
                        lista.Add(new Parametros(@"filesize", di.Tama�o.ToString()));//Tama�o del Documento (en bytes);
                        lista.Add(new Parametros(@"folio", di.Folio.ToString()));// Folio del Documento

                        string proce = "sp_digitalizacion_crud";// Indicarle el Procedimiento

                        if (EjecutarProcedimiento(proce, lista))// Intentar Ejecutar el Procedimiento
                        { return true; }// Ejecuci�n Exitosa, Consulte Tabla
                        else
                        { return false; }// Ejecuci�n NO Exitosa, Consulte Error
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();// Guardar el Error
                        return false;// Indicar que exoste el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Intento de Conexi�n Fallido, Consultar Error
            }
            else
            { return false; }// No es del tipo DigitalizacionesModel
        }

        /// <summary>
        /// M�todo para Ingresar un Registro
        /// </summary>
        /// <returns>Boleano</returns>
        /// <param name="o">Objeto del Tipo Class</param>
        public override bool IngresarRegisto(Object o)
        {

            if (o.GetType() == typeof(DigitalizacionesModel))// Verificar si el objeto es del tipo DigitalizacionesModel
            {
                var di = (DigitalizacionesModel)o; // Castear variable "di" al tipo Digitalizaci�n Model

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();// Crear una lista de par�metros
                        lista.Add(new Parametros(@"opc", "2"));// Mandarle la opci�n al procedimiento
                        lista.Add(new Parametros(@"id", di.Id.ToString()));// Identificador del Registro
                        lista.Add(new Parametros(@"seriedoc", di.SDoctal.SerieDoctal));// Serie Documetal
                        lista.Add(new Parametros(@"docu", Utilerias.BytesToBase64(di.Documento)));// Documento Digitalizado
                        lista.Add(new Parametros(@"nomdocu", di.NombreDoc));//Nombre del Documento Digitalizado
                        lista.Add(new Parametros(@"exte", di.Extension));//Extensi�n del documento digitalizado
                        lista.Add(new Parametros(@"filesize", di.Tama�o.ToString()));
                        lista.Add(new Parametros(@"folio", di.Folio.ToString()));// Folio del Documento

                        string proce = "sp_digitalizacion_crud";// Indicarle el Procedimiento

                        if (EjecutarProcedimiento(proce, lista))// Intentar Ejecutar el Procedimiento
                        { return true; }// Ejecuci�n Exitosa, Consulte Tabla
                        else
                        { return false; }// Ejecuci�n NO Exitosa, Consulte Error
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();// Guardar el Error
                        return false;// Indicar que exoste el error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Intento de Conexi�n Fallido, Consultar Error
            }
            else
            { return false; }// No es del tipo DigitalizacionesModel
        }

        /// <summary>
        /// M�todo para Consultar Todos los Registros
        /// </summary>
        /// <returns>Boleano</returns>
        public override bool ConsultarRegistros()
        {

            if (Abrir())// Intentar Abrir la Conexi�n
            {
                // Intento Exitoso
                try
                {
                    List<Parametros> lista = new List<Parametros>();// Crear una lista de par�metros
                    lista.Add(new Parametros(@"opc", "1"));// Mandarle la opci�n al procedimiento
                    lista.Add(new Parametros(@"id", string.Empty));// Vac�o
                    lista.Add(new Parametros(@"seriedoc", string.Empty));// VAc�o
                    lista.Add(new Parametros(@"docu", string.Empty));// Vacio
                    lista.Add(new Parametros(@"nomdocu", string.Empty));//Vac�o
                    lista.Add(new Parametros(@"exte", string.Empty));//Vac�o
                    lista.Add(new Parametros(@"filesize", string.Empty));//Vac�o
                    lista.Add(new Parametros(@"folio", string.Empty));// Vac�o

                    string proce = "sp_digitalizacion_crud";// Indicarle el Procedimiento

                    if (ConsultarProcedimiento(proce, lista))// Intentar Consultar el Procedimiento
                    { return true; }// Consulta Exitosa, Consulte Tabla
                    else
                    { return false; }// COnsulta NO Exitosa, Consulte Error
                }
                catch (Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToString();// Guardar el Error
                    return false;// Indicar que exoste el error
                }
                finally { Cerrar(); }// Cerrar la conexi�n
            }
            else
            { return false; }// Intento de Conexi�n Fallido, Consultar Error
        }

        /// <summary>
        /// Funci�n para Buscar Expedientes Digitalizados de la Serie Documental
        /// </summary>
        /// <param name="o">Objeto del Tipo Digitalizaci�n</param>
        /// <returns></returns>
        public bool ExpedientesPorSerieDoctal(Object o)
        {
            if (o.GetType() == typeof(DigitalizacionesModel))//Verificar que el objeto sea del tipo Digitalizaciones
            {
                var d = (DigitalizacionesModel)o;//Castear la variable "d" al tipo DigitalizacionModel

                string proce = "sp_digitalizacion_seleccion";//Nombre del Procecimiento a ejecutar

                List<Parametros> lista = new List<Parametros>();//Lista del tipo Par�metros
                lista.Add(new Parametros(@"opc", "1"));//Oci�n a ejecutar dentro del Procedimiento
                lista.Add(new Parametros(@"serie", d.SDoctal.SerieDoctal));//�Serie Documental

                try//Intentar
                {
                    if (Abrir())//Intentar Abrir la Conexi�n
                    {
                        //Conexi�n Exitosa
                        if (ConsultarProcedimiento(proce, lista))//Intentar la Consulta del Procedimiento
                        { return true; }//Consulta Exitosa
                        else
                        { return false; }//Consulta NO Exitosa, consultar Error
                    }
                    else//Conexi�n Fallida
                    {
                        return false;//Indicar que existe un error
                    }
                }
                catch (Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToUpper();//Guardar el Error
                    return false;
                }
                finally { Cerrar(); }//Cerrar la Conexi�n

            }
            else//No es del mismo tipo
            {
                Error = "el objeto no es del tipo digitalizacionmodel".ToUpper();//Indicar el Error
                return false;//Indicar que existe el Error
            }
        }

    }//end DigitalizacionesController

}//end namespace Controladores