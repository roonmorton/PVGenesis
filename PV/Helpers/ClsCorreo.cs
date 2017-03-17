﻿
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace PV
{
    class ClsCorreo
    {
        public bool mailEnviado = false;
        private String mailEmisor;
        private String mailReceptor;
        private String nombreDe;
        private String apellidoDe;
        private SmtpClient cliente;
        private MailAddress mailDe;
        private MailAddress mailPara;
        private MailMessage mensaje;
        private string estado;
        private static string LogFilePath = Application.StartupPath + @"\logCorreo.txt";



        public ClsCorreo(string correo, string nombreDe, string apellidoDe)
        {
            try
            {
                
                //MessageBox.Show(logFile);
                this.mailEmisor = correo;
                this.mailReceptor = correo;
                this.nombreDe = nombreDe;
                this.apellidoDe = apellidoDe;
                this.cliente = new SmtpClient("smtp.gmail.com", 587);
                //this.autenticar();
                this.mailDe = new MailAddress(this.mailEmisor, this.nombreDe + " " + this.apellidoDe, System.Text.Encoding.UTF8);
                this.mailPara = new MailAddress(this.mailReceptor);
                this.mensaje = new MailMessage(this.mailDe, this.mailPara);
                this.estado = "";
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " + ex.Message);
                //file.WriteLine("Exception correo: "+ DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);

                //throw;
            }
        }
        public void autenticar(string mail,string pass)
        {
            try
            {
                this.cliente.Credentials = new System.Net.NetworkCredential(mail, pass);
                this.cliente.EnableSsl = true;
                this.cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                this.cliente.Timeout = 10000;
               
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " + ex.Message);
                //file.WriteLine("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);
                //throw;
            }


        }


       
        public void enviarReporte()
        {
            try
            {
                PV.BL.ClsReportes clsReportes = new PV.BL.ClsReportes();

                DateTime hoy = DateTime.Parse(DateTime.Now.ToString());
                string html = "<div style=\"text-align:center;\"><h1 style=\"font-size:32px; display block;\">Reporte vehiculos " + hoy.ToString("f") +"</h1>" ;
                html += convertDataTableToHTML(clsReportes.RptDiarioVehiculos());
                html +="</div>";
                this.mensaje.Body = html;
                //String someArrows = new String(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                this.mensaje.IsBodyHtml = true;
                this.mensaje.Body += Environment.NewLine;
                this.mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                this.mensaje.Subject = "Reporte vehiculos diario";
                //this.mensaje.Attachments.Add(this.generarReporte());
                this.mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                this.cliente.SendCompleted += new SendCompletedEventHandler(estadoEnvio);
                string UserState = "Mensaje";
                this.cliente.SendAsync(this.mensaje, UserState);
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " + ex.Message);
                //file.WriteLine("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);
//                throw;
            }
            //this.mensaje.Dispose();

        }

        
        private string convertDataTableToHTML(DataTable dt){
            string tablaHtml = "";
            try
            {
                if (dt.Rows.Count < 0)
                {
                    tablaHtml += "<h1>No hay Registros de Vehiculos</h1>";
                }
                tablaHtml += "<table style=\" box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);animation: float 5s infinite; width: 100%;border-collapse: collapse;border: 1px solid #38678f;background: white;text-align:center;\">";
                tablaHtml += "<thead><tr style=\"border-bottom: 1px solid #cccccc;\">";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    tablaHtml += "<th style=\" background: steelblue;height: 54px;font-weight: lighter;text-shadow: 0 1px 0 #38678f;color: white;border: 1px solid #38678f;box-shadow: inset 0px 1px 2px #568ebd;\">" + dt.Columns[i].ColumnName.ToString() + "</th>";
                }
                tablaHtml += "</tr></thead>";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tablaHtml += "<tr style=\"border-bottom: 1px solid #cccccc;\">";
                    for (int j = 0; j < dt.Columns.Count; j++)
                        tablaHtml += "<td style=\"border-right: 1px solid #cccccc; padding:7px\">" + dt.Rows[i][j].ToString() + "</td>";
                    tablaHtml += "<tr>";
                }
                tablaHtml += "</table>";
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " + ex.Message);
                //file.WriteLine("Exception correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);
//                throw;
            }
                return tablaHtml;
        }

        private void estadoEnvio(object sender,AsyncCompletedEventArgs e)
        {
            try
            {
                String ficha = (String)e.UserState;

                if (e.Cancelled)
                {
                    //Mesnaje Cancelado
                    this.estado = "Mensaje cancelado " + ficha + e.Error;
                    mailEnviado = false;
                    //EscribirLog("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " Correo no enviado error");
                    //file.WriteLine("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "Correo no enviado error");
                    EscribirLog("Mensaje", "Mensaje no enviado se cancelo el envio : ");


                }
                if (e.Error != null)
                {
                    //Error en el Envio
                    this.estado = "Error en el envio " + ficha + e.Error;
                    mailEnviado = false;
                    EscribirLog("Mensaje", "Mensaje no enviado se produjo un error : "+ e.Error.HResult);

                    //EscribirLog("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " Correo no enviado, error");
                    //file.WriteLine("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "Correo no enviado, error");

                }
                else
                {
                    //Mensaje Enviado
                    this.estado = "Mensaje Enviado " + ficha;
                    mailEnviado = true;
                    BL.ClsParametros clsParametros = new BL.ClsParametros();
                    clsParametros.grabarModificarPCorreo(DateTime.Now.Day.ToString());
                    EscribirLog("Mensaje", "Mensje Enviado correctamente...");

                    //EscribirLog("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " Correo enviado");
                    //file.WriteLine("Mensaje correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") +"Correo enviado");

                }
                //MessageBox.Show(this.estado);
                //mailEnviado = true;
            }
            catch (Exception ex)
            {
                //EscribirLog("Exception Correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + " " +ex.Message);
                //file.WriteLine("Exception Correo: " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + ex.Message);
                EscribirLog("Excepcion", ex.Message);

//                throw;
            }

        }

        

        private Attachment generarReporte()
        {
            //string file = System.IO.Path.GetFileName("C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf");
            string file = "C:\\Users\\Soporte\\Desktop\\19.02.2017.0.20.pdf";
            return new Attachment(file);
        }


        private void EscribirLog(string tipo, string data)
        {

            try
            {
                string LogFilePath = Application.StartupPath + @"\logCorreo.txt";
                StreamWriter LogFile;
                if (File.Exists(LogFilePath))
                    LogFile = new StreamWriter(LogFilePath, true);
                else
                    LogFile = new StreamWriter(LogFilePath);
                LogFile.WriteLine(tipo + ": - " + DateTime.Now.ToString("dd/MM/yyy hh:mm") + "- "+ data);
                LogFile.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
