using System;
using Gtk;
using PortafolioFinal_Server_Ventana;
using System.Threading;


public partial class MainWindow : Gtk.Window
{	
	public Thread HiloServidor;
	public Thread HiloEstado;
	public Clase_Servidor Servidor;
	public static string stringIP;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		btnTerminar.Sensitive = false;
		labelEstadoServidor.LabelProp = @"<span foreground=""red"">        Desconectado</span>";

		Servidor = new Clase_Servidor();
		HiloServidor = new Thread(Servidor.ClaseServidor);
		HiloEstado = new Thread(CambioEstadoBotones);

		HiloServidor.Start();
		HiloServidor.Abort();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void btnCerrar_Clicked (object sender, EventArgs e)
	{                          
		Gtk.Main.Quit();
	}

	protected void btn_Iniciar_Clicked (object sender, EventArgs e)
	{
		if (textboxIP.Text == string.Empty) {
			MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Campo IP no puede estar vacío.");
			md.Run ();
			md.Destroy();
			return;
		}

		Servidor = new Clase_Servidor();
		HiloServidor = new Thread(Servidor.ClaseServidor);
		HiloEstado = new Thread(CambioEstadoBotones);

		stringIP = textboxIP.Text;

		HiloServidor.Start();
		Thread.Sleep(800);
		HiloEstado.Start ();
	}

	protected void btnTerminar_Clicked (object sender, EventArgs e)
	{
		Clase_Servidor.CerrarServidor();
		HiloServidor.Abort();

		labelEstadoServidor.LabelProp = @"<span foreground=""red"">        Desconectado.</span>";

		btnIniciar.Sensitive = true;
		btnCerrar.Sensitive = true;
		btnTerminar.Sensitive = false;

		textboxIP.Sensitive = true;
		textboxIP.Text = "";

	}

	protected void CambioEstadoBotones ()
	{
		if (Clase_Servidor.EstadoServidor) {
			btnIniciar.Sensitive = false;
			btnCerrar.Sensitive = false;
			btnTerminar.Sensitive = true;

			textboxIP.Sensitive = false;
			
			labelEstadoServidor.LabelProp = @"<span foreground=""darkgreen"">        ¡Conectado!</span>";
		} 
	}
}
