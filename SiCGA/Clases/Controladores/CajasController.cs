///////////////////////////////////////////////////////////
//  CajasController.cs
//  Implementation of the Class CajasController
//  Generated by Enterprise Architect
//  Created on:      10-mar.-2017 13:18:30
//  Original author: Ing. Al�n Adalberto Ortiz P�rez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SiCGA.Clases.Modelos;




namespace SiCGA.Clases.Controladores
{
    public class CajasController : Metodos
    {
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public CajasController()
        {

        }
        /// <summary>
        /// Destructor de la Clase
        /// </summary>
        ~CajasController()
        {

        }

        /// <summary>
        /// M�todo para Consultar un Registro del Modelo Cajas
        /// </summary>
        /// <param name="o">Objeto del Tipo CajasModel</param>
        /// <returns>Boleano</returns>
        public override bool ConsultarRegistro(object o)
        {

            if (o.GetType() == typeof(CajasModel))// Verificar que el Objeto dea del Tipo CajasModel
            {
                var c = (CajasModel)o; // Castaer la variable "c" al tipo CajasModel

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "4"));// Se le indica la Opci�n al Procedimiento
                        lista.Add(new Parametros(@"id", c.Id.ToString())); // Identificdor del Registro
                        lista.Add(new Parametros(@"num", string.Empty));
                        lista.Add(new Parametros(@"fol_car", string.Empty));
                        lista.Add(new Parametros(@"a�o", string.Empty));
                        lista.Add(new Parametros(@"n_d_m", string.Empty));
                        lista.Add(new Parametros(@"idtrans", string.Empty));

                        string proce = "sp_cajas_crud";

                        if (ConsultarProcedimiento(proce, lista))// Consultar el Procedimiento
                        { return true; }// Consulta Exitosa, Cnsultar Tabla
                        else
                        { return false; }// Consulta NO Exitosa, Consultar Error
                    }
                    catch (Exception e)// Atrapar el Error
                    {
                        Error = e.Message.ToString();// Atrapa el error
                        return false; // Indica que existe un error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Intento Fallido, Consultar Error
            }
            else
            { return false; }// No es del Tipo CajasModel
        }

        /// <summary>
        /// M�todo para Actualizar Registro
        /// </summary>
        /// <param name="o">Objeto del Tipo CajasModel</param>
        /// <returns>Boleano</returns>
        public override bool ActualizarRegistro(object o)
        {

            if (o.GetType() == typeof(CajasModel))// Verificar que el Objeto dea del Tipo CajasModel
            {
                var c = (CajasModel)o; // Castaer la variable "c" al tipo CajasModel

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "3"));// Se le indica la Opci�n al Procedimiento
                        lista.Add(new Parametros(@"id", c.Id.ToString())); // Identificdor del Registro
                        lista.Add(new Parametros(@"num", c.Numero.ToString()));// N�mero de caja
                        lista.Add(new Parametros(@"fol_car", c.Folders_Carpetas.ToString()));// N�mero de Folders/Carpetas de la Caja
                        lista.Add(new Parametros(@"a�o", c.A�o.ToString()));// A�o de la Carpeta
                        lista.Add(new Parametros(@"n_d_m", c.NdeM.ToString()));// Ord�n de un Grupo de Cajas
                        lista.Add(new Parametros(@"idtrans", c.Transferencia.Id.ToString()));// Identificador de la transferencia

                        string proce = "sp_cajas_crud";// Nombre del Procedimiento

                        if (EjecutarProcedimiento(proce, lista))// Ejecutar el Procedimiento
                        { return true; }// Ejecuci�n Exitosa, Cnsultar Tabla
                        else
                        { return false; }// Ejecuci�n NO Exitosa, Consultar Error
                    }
                    catch (Exception e)// Atrapar el Error
                    {
                        Error = e.Message.ToString();// Atrapa el error
                        return false; // Indica que existe un error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Intento Fallido, Consultar Error
            }
            else
            { return false; }// No es del Tipo CajasModel
        }

        /// <summary>
        /// M�todo para Ingresar Registro a Cajas
        /// </summary>
        /// <param name="o">Objeto del Tipo CajasModel</param>
        /// <returns>Boleano</returns>
        public override bool IngresarRegisto(object o)
        {

            if (o.GetType() == typeof(CajasModel))// Verificar que el Objeto dea del Tipo CajasModel
            {
                var c = (CajasModel)o; // Castaer la variable "c" al tipo CajasModel

                if (Abrir())// Intentar Abrir la Conexi�n
                {
                    // Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "2"));// Se le indica la Opci�n al Procedimiento
                        lista.Add(new Parametros(@"id", c.Id.ToString())); // Identificdor del Registro
                        lista.Add(new Parametros(@"num", c.Numero.ToString()));// N�mero de caja
                        lista.Add(new Parametros(@"fol_car", c.Folders_Carpetas.ToString()));// N�mero de Folders/Carpetas de la Caja
                        lista.Add(new Parametros(@"a�o", c.A�o.ToString()));// A�o de la Carpeta
                        lista.Add(new Parametros(@"n_d_m", c.NdeM.ToString()));// Ord�n de un Grupo de Cajas
                        lista.Add(new Parametros(@"idtrans", c.Transferencia.Id.ToString()));// Identificador de la transferencia

                        string proce = "sp_cajas_crud";// Nombre del Procedimiento

                        if (EjecutarProcedimiento(proce, lista))// Ejecutar el Procedimiento
                        { return true; }// Ejecuci�n Exitosa, Cnsultar Tabla
                        else
                        { return false; }// Ejecuci�n NO Exitosa, Consultar Error
                    }
                    catch (Exception e)// Atrapar el Error
                    {
                        Error = e.Message.ToString();// Atrapa el error
                        return false; // Indica que existe un error
                    }
                    finally { Cerrar(); }// Cerrar la conexi�n
                }
                else
                { return false; }// Intento Fallido, Consultar Error
            }
            else
            { return false; }// No es del Tipo CajasModel
        }
        /// <summary>
        /// M�todo para Consultar Todos Los Registros
        /// </summary>
        /// <returns>Boleano</returns>
		public override bool ConsultarRegistros()
        {

            if (Abrir())// Intentar Abrir la Conexi�n
            {
                // Intento Exitoso
                try
                {
                    List<Parametros> lista = new List<Parametros>();
                    lista.Add(new Parametros(@"opc", "4"));// Se le indica la Opci�n al Procedimiento
                    lista.Add(new Parametros(@"id", string.Empty)); // Identificdor del Registro
                    lista.Add(new Parametros(@"num", string.Empty));// N�mero de caja
                    lista.Add(new Parametros(@"fol_car", string.Empty));// N�mero de Folders/Carpetas de la Caja
                    lista.Add(new Parametros(@"a�o", string.Empty));// A�o de la Carpeta
                    lista.Add(new Parametros(@"n_d_m", string.Empty));// Ord�n de un Grupo de Cajas
                    lista.Add(new Parametros(@"idtrans", string.Empty));// Identificador de la transferencia

                    string proce = "sp_cajas_crud";// Nombre del Procedimiento

                    if (ConsultarProcedimiento(proce, lista))// Consultar el Procedimiento
                    { return true; }// Consulta Exitosa, Cnsultar Tabla
                    else
                    { return false; }// Consulta NO Exitosa, Consultar Error
                }
                catch (Exception e)// Atrapar el Error
                {
                    Error = e.Message.ToString();// Atrapa el error
                    return false; // Indica que existe un error
                }
                finally { Cerrar(); }// Cerrar la conexi�n
            }
            else
            { return false; }// Intento Fallido, Consultar Error
        }

    }//end CajasController

}//end namespace Controladores