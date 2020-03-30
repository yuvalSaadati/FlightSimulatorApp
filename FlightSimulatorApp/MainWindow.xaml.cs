using System;
using System.Net.Sockets;
using System.Windows;
using FlightSimulatorApp.Models;
using FlightSimulatorApp.ViewModels;

namespace FlightSimulatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model myModel;
        JoystickVM joystickVM;
        [Obsolete]
        public MainWindow()
        {
            InitializeComponent();
            TcpClient telnetClient = new TcpClient();
            myModel = new Model(telnetClient);
            joystickVM = new JoystickVM(myModel);
            this.DataContext = joystickVM;
        }
    }
}
