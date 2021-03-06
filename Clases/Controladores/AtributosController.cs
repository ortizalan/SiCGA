﻿using System.Collections.Generic;
using SADI.Clases.Modelos;
using System;

namespace SADI.Clases.Controladores
{
    /// <summary>
    /// Controlador para el Modelo Accesibilidad
    /// </summary>
    class AtributosController : Metodos
    {
        /// <summary>
        /// Actualizar Registro del Modelo
        /// </summary>
        /// <param name="o">Objeto del Tipo AccesibilidadModel</param>
        /// <returns>Boleano</returns>
        public override bool ActualizarRegistro(object o)
        {
            if (o.GetType() == typeof(AtributosModel))//Verificar que el Objeto sea del Modelo Accesibilidad
            {
                //SI son del mismo tipo
                var a = (AtributosModel)o;//Castear la Variable "a" al tipo AccesibilidadModel
                try
                {
                    if (Abrir())//Intentar Abrir la Conexión
                    {
                        //Intento Exitoso
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "3"));//Indicarle una Opción al Procedimiento
                        lista.Add(new Parametros(@"id", a.Id.ToString()));//Identificador del Registro
                        lista.Add(new Parametros(@"usuario", a.Usuario.Id.ToString()));//Identificador del Usuario
                        lista.Add(new Parametros(@"serie", a.Serie.Id.ToString()));//Identificador de la Serie
                        lista.Add(new Parametros(@"seccion", a.Seccion.Id));//Identificador de la Sección
                        lista.Add(new Parametros(@"tema", a.Temas.Id.ToString()));//Identificador del Tema

                        string proce = "sp_atributos_crud";//Indicarle el Nombre al Procedimiento

                        if (EjecutarProcedimiento(proce, lista))//Intentar Ejecución del Procedimiento
                        { return true; /* Intento Exitoso */ }

                        else//Intento NO Exitoso, Consultar Error
                        { return false; }
                    }
                    else//Intento NO Existoso, Consultar Error
                    { return false; }
                }
                catch (Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToString();//Guardar el Error
                    return false;//Indicar que existe el Error
                }
                finally { Cerrar(); }//Cerrar la Conexión
            }
            else//No son del Mismo Tipo
            {
                Error = "objeto no es del mismo tipo del modelo.".ToUpper();
                return false;
            }
        }
        /// <summary>
        /// Consultar Registro por ID del Modelo
        /// </summary>
        /// <param name="o">Objeto del Tipo AccesibilidadModel</param>
        /// <returns>Boleano</returns>
        public override bool ConsultarRegistro(object o)
        {
            if (o.GetType() == typeof(AtributosModel))//Verificar que el Objeto sea del Modelo Accesibilidad
            {
                //SI son del mismo tipo
                var a = (AtributosModel)o;//Castear la Variable "a" al tipo AccesibilidadModel
                try
                {
                    if (Abrir())//Intentar Abrir la Conexión
                    {
                        //Intento Exitoso
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "4"));//Indicarle una Opción al Procedimiento
                        lista.Add(new Parametros(@"id", a.Id.ToString()));//Identificador del Registro
                        lista.Add(new Parametros(@"usuario", string.Empty));//Vacío
                        lista.Add(new Parametros(@"serie", string.Empty));//Vacío
                        lista.Add(new Parametros(@"seccion", string.Empty));//Vacío
                        lista.Add(new Parametros(@"tema", string.Empty));//Vacío

                        string proce = "sp_atributos_crud";//Indicarle el Nombre al Procedimiento

                        if (ConsultarProcedimiento(proce, lista))//Intentar Consulta del Procedimiento
                        { return true; /* Consulta Exitosa */ }

                        else//Consulta NO Exitosa, Consultar Error
                        { return false; }
                    }
                    else//Intento NO Existoso, Consultar Error
                    { return false; }
                }
                catch (Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToString();//Guardar el Error
                    return false;//Indicar que existe el Error
                }
                finally { Cerrar(); }//Cerrar la COnexión
            }
            else//No son del Mismo Tipo
            {
                Error = "objeto no es del mismo tipo que el modelo".ToUpper();
                return false;
            }
        }
        /// <summary>
        /// Consultar Todos Los Registros
        /// </summary>
        /// <returns>Boleano</returns>
        public override bool ConsultarRegistros()
        {
            try
            {
                if (Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    List<Parametros> lista = new List<Parametros>();
                    lista.Add(new Parametros(@"opc", "1"));//Indicarle una Opción al Procedimiento
                    lista.Add(new Parametros(@"id", string.Empty));//Vacío
                    lista.Add(new Parametros(@"usuario", string.Empty));//Vacío
                    lista.Add(new Parametros(@"serie", string.Empty));//Vacío
                    lista.Add(new Parametros(@"seccion", string.Empty));//Vacío
                    lista.Add(new Parametros(@"tema", string.Empty));//Vacío

                    string proce = "sp_atributos_crud";//Indicarle el Nombre al Procedimiento

                    if (ConsultarProcedimiento(proce, lista))//Intentar Consulta del Procedimiento
                    { return true; /* Consulta Exitosa */ }

                    else//Consulta NO Exitosa, Consultar Error
                    { return false; }
                }
                else//Intento NO Existoso, Consultar Error
                { return false; }
            }
            catch (Exception e)//Atrapar el Error
            {
                Error = e.Message.ToString();//Guardar el Error
                return false;//Indicar que existe el error
            }
            finally { Cerrar(); }//Cerrar la Conexión
        }
        /// <summary>
        /// Ingresar un Registro al Modelo
        /// </summary>
        /// <param name="o">Objeto del tipo AccesibilidadModel</param>
        /// <returns>Boleano</returns>
        public override bool IngresarRegisto(object o)
        {
            if (o.GetType() == typeof(AtributosModel))//Verificar que el Objeto sea del Modelo Accesibilidad
            {
                //SI son del mismo tipo
                var a = (AtributosModel)o;//Castear la Variable "a" al tipo AccesibilidadModel
                try
                {
                    if (Abrir())//Intentar Abrir la Conexión
                    {
                        //Intento Exitoso
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "2"));//Indicarle una Opción al Procedimiento
                        lista.Add(new Parametros(@"id", a.Id.ToString()));//Identificador del Registro
                        lista.Add(new Parametros(@"usuario", a.Usuario.Id.ToString()));//Identificador del Usuario
                        lista.Add(new Parametros(@"serie", a.Serie.Id.ToString()));//Identificador de la Serie
                        lista.Add(new Parametros(@"seccion", a.Seccion.Id));//Identificador de la Sección
                        lista.Add(new Parametros(@"tema", a.Temas.Id.ToString()));//Identificador del Tema

                        string proce = "sp_atributos_crud";//Indicarle el Nombre al Procedimiento

                        if (EjecutarProcedimiento(proce, lista))//Intentar Ejecución del Procedimiento
                        { return true; /* Intento Exitoso */ }

                        else//Intento NO Exitoso, Consultar Error
                        { return false; }
                    }
                    else//Intento NO Existoso, Consultar Error
                    { return false; }
                }
                catch (Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToString();//Guardar el Error
                    return false;//Indicar que existe el error
                }
                finally { Cerrar(); }//Cerrar la Conexión
            }
            else//No son del Mismo Tipo
            { return false; }
        }
        /// <summary>
        /// Función para el Ingreso Automático de un Tema
        /// </summary>
        /// <param name="o">Objeto del Tipo AtributosModel</param>
        /// <returns>Boleano</returns>
        public bool IngresoAutomaticoAtributo(object o)
        {
            if(o.GetType() == typeof(AtributosModel))//Verificar que el Objeto sea del tipo de Controlador Adecuado
            {
                var a = (AtributosModel)o;
                // Mismo tipo
                string proce = "sp_atributos_seleccion";//Nombre del Procedimiento
                List<Parametros> lista = new List<Parametros>();
                lista.Add(new Parametros(@"opc", "4"));//Indicar la opción a ejecutar dentro del procedimiento
                lista.Add(new Parametros(@"usr", a.Usuario.Id.ToString()));//Identificador del Usuario
                lista.Add(new Parametros(@"sec", a.Seccion.Id));//Identificador de la Sección
                lista.Add(new Parametros(@"ser", a.Serie.Id.ToString()));//Identificador de la Serie
                lista.Add(new Parametros(@"tema", a.Temas.Id.ToString()));//Identificador del Tema

                if(Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    try
                    {
                        if(EjecutarProcedimiento(proce, lista))//Intentar Ejecutar el Procedimiento
                        { return true; }//Intento Exitoso
                        else//Intento NO exitoso, Consulte Error
                        { return false; }
                    }
                    catch(Exception e)
                    {
                        Error = e.Message.ToString();
                        return false;
                    }
                    finally { Cerrar(); }
                }
                else//Intento no Exitoso
                {
                    return false;
                }

            }
            else//No son del mismo tipo
            {
                Error = "el objeto no es del tipo esperado.".ToUpper();//Indicarl el Error
                return false;//Señalar que existe error
            }
        }
    }
}
