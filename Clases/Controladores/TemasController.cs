﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADI.Clases.Modelos;
using SADI.Clases;

namespace SADI.Clases.Controladores
{
    /// <summary>
    /// Clase Controladora para el Modelo Temas
    /// </summary>
    class TemasController : Metodos
    {
        /// <summary>
        /// Actualizar Registro del Modelo
        /// </summary>
        /// <param name="o">Objeto del tipo TemasModel</param>
        /// <returns>Boleano</returns>
        public override bool ActualizarRegistro(object o)
        {
            if (o.GetType() == typeof(TemasModel))//Verificar si el Objeto es del Tipo TemasModel
            {
                //SI es del mismo tipo
                var t = (TemasModel)o;//Castear la variable "t" al tipo TemasModel

                if (Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "3"));//Opción a Ejecutar en el Procedimiento
                        lista.Add(new Parametros(@"id", t.Id.ToString()));//Identificador del Modelo
                        lista.Add(new Parametros(@"seccion", t.Seccion.Id));//Identificador de la Sección
                        lista.Add(new Parametros(@"serie", t.Serie.Id.ToString()));//Identificador de la Serie
                        lista.Add(new Parametros(@"tema", t.Tema));//Descripción del Tema

                        string proce = "sp_temas_crud";// Nombre del Procedimiento a Ejecutar

                        if (EjecutarProcedimiento(proce, lista))//Intentar Ejecutar el Procedimiento
                        {
                            return true;//Ejecución Exitosa
                        }
                        else//Ejecución NO Exitosa, Consutar Error
                        { return false; }
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();//Guardar el Error
                        return false;//Indicar que existe el Error
                    }
                    finally { Cerrar(); }//Cerrar la conexión
                }
                else//Intento NO Exitoso, Consultar Error
                {
                    return false;
                }

            }
            else//No son del mismo tipo
            {
                return false;
            }
        }
        /// <summary>
        /// Consultar un Registro
        /// </summary>
        /// <param name="o">Objeto del Tipo TemasModel</param>
        /// <returns></returns>
        public override bool ConsultarRegistro(object o)
        {
            if (o.GetType() == typeof(TemasModel))//Verificar si el Objeto es del Tipo TemasModel
            {
                //SI es del mismo tipo
                var t = (TemasModel)o;//Castear la variable "t" al tipo TemasModel

                if (Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "4"));//Opción a Ejecutar en el Procedimiento
                        lista.Add(new Parametros(@"id", t.Id.ToString()));//Identificador del Modelo
                        lista.Add(new Parametros(@"seccion", string.Empty));//Vacío
                        lista.Add(new Parametros(@"serie", string.Empty));//Vacío
                        lista.Add(new Parametros(@"tema", string.Empty));//Vacío

                        string proce = "sp_temas_crud";// Nombre del Procedimiento a Ejecutar

                        if (ConsultarProcedimiento(proce, lista))//Intentar Consultar el Procedimiento
                        {
                            return true;//Consulta Exitosa
                        }
                        else//Consulta NO Exitosa, Consutar Error
                        { return false; }
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();//Guardar el Error
                        return false;//Indicar que existe el Error
                    }
                    finally { Cerrar(); }//Cerrar la conexión
                }
                else//Intento NO Exitoso, Consultar Error
                {
                    return false;
                }

            }
            else//No son del mismo tipo
            {
                return false;
            }
        }
        /// <summary>
        /// Consultar Todos Los Registros del Modelo
        /// </summary>
        /// <returns>Boleano</returns>
        public override bool ConsultarRegistros()
        {
            if (Abrir())//Intentar Abrir la Conexión
            {
                //Intento Exitoso
                try
                {
                    List<Parametros> lista = new List<Parametros>();
                    lista.Add(new Parametros(@"opc", "1"));//Opción a Ejecutar en el Procedimiento
                    lista.Add(new Parametros(@"id", string.Empty));//Vacío
                    lista.Add(new Parametros(@"seccion", string.Empty));//Vacío
                    lista.Add(new Parametros(@"serie", string.Empty));//Vacío
                    lista.Add(new Parametros(@"tema", string.Empty));//Vacío

                    string proce = "sp_temas_crud";// Nombre del Procedimiento a Ejecutar

                    if (ConsultarProcedimiento(proce, lista))//Intentar Consultar el Procedimiento
                    {
                        return true;//Consulta Exitosa
                    }
                    else//Consulta NO Exitosa, Consutar Error
                    { return false; }
                }
                catch (Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToString();//Guardar el Error
                    return false;//Indicar que existe el Error
                }
                finally { Cerrar(); }//Cerrar la conexión
            }
            else//Intento NO Exitoso, Consultar Error
            {
                return false;
            }
        }
        /// <summary>
        /// Ingresar un Registro al Modelo
        /// </summary>
        /// <param name="o">Objeto del tipo TemasModel</param>
        /// <returns>Boleano</returns>
        public override bool IngresarRegisto(object o)
        {
            if (o.GetType() == typeof(TemasModel))//Verificar si el Objeto es del Tipo TemasModel
            {
                //SI es del mismo tipo
                var t = (TemasModel)o;//Castear la variable "t" al tipo TemasModel

                if (Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    try
                    {
                        List<Parametros> lista = new List<Parametros>();
                        lista.Add(new Parametros(@"opc", "2"));//Opción a Ejecutar en el Procedimiento
                        lista.Add(new Parametros(@"id", t.Id.ToString()));//Identificador del Modelo
                        lista.Add(new Parametros(@"seccion", t.Seccion.Id));//Identificador de la Sección
                        lista.Add(new Parametros(@"serie", t.Serie.Id.ToString()));//Identificador de la Serie
                        lista.Add(new Parametros(@"tema", t.Tema));//Descripción del Tema

                        string proce = "sp_temas_crud";// Nombre del Procedimiento a Ejecutar

                        if (EjecutarProcedimiento(proce, lista))//Intentar Ejecutar el Procedimiento
                        {
                            return true;//Ejecución Exitosa
                        }
                        else//Ejecución NO Exitosa, Consutar Error
                        { return false; }
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();//Guardar el Error
                        return false;//Indicar que existe el Error
                    }
                    finally { Cerrar(); }//Cerrar la conexión
                }
                else//Intento NO Exitoso, Consultar Error
                {
                    return false;
                }

            }
            else//No son del mismo tipo
            {
                return false;
            }
        }
        /// <summary>
        /// Realizar la Consulta del Tema por Serie y Sección
        /// </summary>
        /// <param name="o">Objeto del Tipo AtributosModel</param>
        /// <returns>Boleano</returns>
        public bool ConsultarTemaXUsuarioSerieSeccion(object o)
        {
            if (o.GetType() == typeof(AtributosModel))//Verificar que el Objeto sea del Mismo tipo de TemasModel
            {
                //SI es del mismo tipo
                var t = (AtributosModel)o;//Castear la variable "t" al tipo TemasModel

                string proce = "sp_combos_usuarios_atributos";//Nombre del procedimiento
                List<Parametros> lista = new List<Parametros>();//Lista de Parámetros
                lista.Add(new Parametros(@"opc", "3"));//OPción a ejecutar dentro del procedimiento
                lista.Add(new Parametros(@"usr", t.Usuario.Id.ToString()));//Identificador del Usuario
                lista.Add(new Parametros(@"sec", t.Seccion.Id));//Identificador de la Sección
                lista.Add(new Parametros(@"ser", t.Serie.Id.ToString()));//Identificador de la serie

                if(Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    try
                    {
                        if(ConsultarProcedimiento(proce,lista))//Intentar la Consulta
                        { return true; }//Intento Exitoso
                        else//Intento NO Exitoso, COnsultar Error
                        { return false; }
                    }
                    catch(Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();// Guardar el error
                        return false;//Indicar que existe el error
                    }
                    finally { Cerrar(); }//Cerrar la Coneión
                }
                else//Intento NO Exitoso, Cosultar Error
                {
                    return false;
                }
            }
            else//No son del mismo tipo
            {
                Error = "no es el objeto del tipo TemasModel.".ToUpper();
                return false;
            }
        }
        /// <summary>
        /// Realizar Consulta del Tema por Usuario, Seccion y Serie
        /// </summary>
        /// <param name="o">Objeto del tipo TemasModel</param>
        /// <returns>Boleano</returns>
        public bool ConsultarTemaXSerieSeccion(object o)
        {
            if (o.GetType() == typeof(TemasModel))//Verificar que el Objeto sea del Mismo tipo de TemasModel
            {
                //SI es del mismo tipo
                var t = (TemasModel)o;//Castear la variable "t" al tipo TemasModel

                string proce = "sp_combos_usuarios_atributos";//Nombre del procedimiento
                List<Parametros> lista = new List<Parametros>();//Lista de Parámetros
                lista.Add(new Parametros(@"opc", "5"));//OPción a ejecutar dentro del procedimiento
                lista.Add(new Parametros(@"usr", string.Empty));//Identificador del Usuario
                lista.Add(new Parametros(@"sec", t.Seccion.Id));//Identificador de la Sección
                lista.Add(new Parametros(@"ser", t.Serie.Id.ToString()));//Identificador de la serie

                if (Abrir())//Intentar Abrir la Conexión
                {
                    //Intento Exitoso
                    try
                    {
                        if (ConsultarProcedimiento(proce, lista))//Intentar la Consulta
                        { return true; }//Intento Exitoso
                        else//Intento NO Exitoso, COnsultar Error
                        { return false; }
                    }
                    catch (Exception e)//Atrapar el Error
                    {
                        Error = e.Message.ToString();// Guardar el error
                        return false;//Indicar que existe el error
                    }
                    finally { Cerrar(); }//Cerrar la Coneión
                }
                else//Intento NO Exitoso, Cosultar Error
                {
                    return false;
                }
            }
            else//No son del mismo tipo
            {
                Error = "no es el objeto del tipo TemasModel.".ToUpper();
                return false;
            }
        }
        /// <summary>
        /// Función para consultar el Último Registro Ingresado
        /// </summary>
        /// <returns>Boleano</returns>
        public bool ConsultarUltimoRegistroIngresado()
        {
            string proce = "sp_temas_seleccion";
            List<Parametros> lista = new List<Parametros>();
            lista.Add(new Parametros(@"opc", "1"));//Indicarle la opción a ejecutar dentro del procedimiento
            lista.Add(new Parametros(@"id", string.Empty));//Vacío
            lista.Add(new Parametros(@"sec", string.Empty));//Vacío
            lista.Add(new Parametros(@"ser", string.Empty));//Vacío
            lista.Add(new Parametros(@"tema", string.Empty));//Vacío

            if(Abrir())//Intentar Abrir la conexión
            {
                try//Intentar
                {
                    if (ConsultarProcedimiento(proce, lista))//Consultar el Procedimiento
                    { return true; }//Intento Exitoso
                    else//Intento Fallido
                    { return false; }
                }
                catch(Exception e)//Atrapar el Error
                {
                    Error = e.Message.ToString();//Guardar el Error
                    return false;//Indicar que existe el Error
                }
                finally { Cerrar(); }//Cerrar la Conexión
            }
            else//Intento Fallido
            {
                return false;
            }
        }
    }
}
