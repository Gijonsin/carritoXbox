using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;

namespace carritoXbox
{
    public partial class Form1 : Form
    {

        SerialPort sp = new SerialPort();
        Controller controller;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller(UserIndex.One);
            timer = new Timer();
            timer.Interval = 100; // Intervalo de 100ms
            timer.Tick += Timer_Tick;
            if (!controller.IsConnected)
            {
                MessageBox.Show("El controlador no está conectado.");
                return; // Sale si no está conectado
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();

            if (puertos.Length == 0)
            {
                MessageBox.Show("No se detectaron puertos.");
            }
            else
            {
                cb_Puertos.DataSource = puertos;
            }
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = cb_Puertos.Text;
                sp.BaudRate = 9600; // Asegúrate de que la velocidad en baudios coincida con la del módulo Bluetooth
                sp.Open();
                MessageBox.Show("Conectado al puerto " + sp.PortName);
                timer.Start(); // Iniciar el temporizador para leer el estado del controlador
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (controller.GetState(out var state) && sp.IsOpen)
            {
                var leftThumb = state.Gamepad.LeftThumbY;   // Joystick izquierdo para girar
                var rightThumb = state.Gamepad.RightThumbX; // Joystick derecho para avanzar/retroceder

                // Avanza si el joystick derecho está hacia adelante
                if (rightThumb > 5000)
                {
                    sp.Write("w"); // Comando para avanzar
                }
                // Retrocede si el joystick derecho está hacia atrás
                else if (rightThumb < -5000)
                {
                    sp.Write("s"); // Comando para retroceder
                }
                // Gira a la derecha si el joystick izquierdo está hacia la derecha
                else if (leftThumb > 5000)
                {
                    sp.Write("d"); // Comando para girar a la derecha
                }
                // Gira a la izquierda si el joystick izquierdo está hacia la izquierda
                else if (leftThumb < -5000)
                {
                    sp.Write("a"); // Comando para girar a la izquierda
                }
                // Si no hay movimiento, detener el carrito
                else
                {
                    sp.Write("p"); // Comando para detenerse
                }
            }
        }


        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();

            if (puertos.Length == 0)
            {
                MessageBox.Show("No se encontraron puertos disponibles.");
            }
            else
            {
                cb_Puertos.DataSource = puertos;
            }
        }
    }
}
