
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.VBox ContenedorVentana;
	private global::Gtk.VBox ContenedorSuperior;
	private global::Gtk.Label TituloVentana;
	private global::Gtk.HBox Grupo1;
	private global::Gtk.Label labelAccioneServidor;
	private global::Gtk.HSeparator hseparator2;
	private global::Gtk.HBox ContenedorBotones;
	private global::Gtk.Entry textboxIP;
	private global::Gtk.Button btnIniciar;
	private global::Gtk.Button btnTerminar;
	private global::Gtk.Label labelEstadoServidor;
	private global::Gtk.VBox ContenedorMedio;
	private global::Gtk.HBox Grupo2;
	private global::Gtk.Label labelRegistro;
	private global::Gtk.HSeparator hseparator3;
	private global::Gtk.VBox RegistroEventos;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView textviewRegistro;
	private global::Gtk.VBox ContenedorMensajes;
	private global::Gtk.HBox hbox10;
	private global::Gtk.Label label8;
	private global::Gtk.HSeparator hseparator4;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TextView textviewMensajes;
	private global::Gtk.HBox hbox11;
	private global::Gtk.Entry entry1;
	private global::Gtk.Button btnEnviar;
	private global::Gtk.VBox vbox53;
	private global::Gtk.HSeparator hseparator5;
	private global::Gtk.Button btnCerrar;
	private global::Gtk.Label labelCreditos;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 500;
		this.HeightRequest = 460;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.HeightRequest = 0;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ContenedorVentana = new global::Gtk.VBox ();
		this.ContenedorVentana.WidthRequest = 505;
		this.ContenedorVentana.Name = "ContenedorVentana";
		this.ContenedorVentana.Spacing = 6;
		// Container child ContenedorVentana.Gtk.Box+BoxChild
		this.ContenedorSuperior = new global::Gtk.VBox ();
		this.ContenedorSuperior.Name = "ContenedorSuperior";
		this.ContenedorSuperior.Spacing = 6;
		// Container child ContenedorSuperior.Gtk.Box+BoxChild
		this.TituloVentana = new global::Gtk.Label ();
		this.TituloVentana.Name = "TituloVentana";
		this.TituloVentana.LabelProp = global::Mono.Unix.Catalog.GetString ("Modulo Administración Chat - Programación 1");
		this.TituloVentana.UseMarkup = true;
		this.ContenedorSuperior.Add (this.TituloVentana);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.ContenedorSuperior [this.TituloVentana]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child ContenedorSuperior.Gtk.Box+BoxChild
		this.Grupo1 = new global::Gtk.HBox ();
		this.Grupo1.Name = "Grupo1";
		this.Grupo1.Spacing = 6;
		// Container child Grupo1.Gtk.Box+BoxChild
		this.labelAccioneServidor = new global::Gtk.Label ();
		this.labelAccioneServidor.Name = "labelAccioneServidor";
		this.labelAccioneServidor.LabelProp = global::Mono.Unix.Catalog.GetString ("Acciones Servidor:");
		this.labelAccioneServidor.UseMarkup = true;
		this.labelAccioneServidor.Wrap = true;
		this.Grupo1.Add (this.labelAccioneServidor);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.Grupo1 [this.labelAccioneServidor]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child Grupo1.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.Grupo1.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.Grupo1 [this.hseparator2]));
		w3.Position = 1;
		this.ContenedorSuperior.Add (this.Grupo1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.ContenedorSuperior [this.Grupo1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child ContenedorSuperior.Gtk.Box+BoxChild
		this.ContenedorBotones = new global::Gtk.HBox ();
		this.ContenedorBotones.Name = "ContenedorBotones";
		this.ContenedorBotones.Spacing = 6;
		// Container child ContenedorBotones.Gtk.Box+BoxChild
		this.textboxIP = new global::Gtk.Entry ();
		this.textboxIP.WidthRequest = 0;
		this.textboxIP.CanFocus = true;
		this.textboxIP.Name = "textboxIP";
		this.textboxIP.IsEditable = true;
		this.textboxIP.InvisibleChar = '●';
		this.ContenedorBotones.Add (this.textboxIP);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.ContenedorBotones [this.textboxIP]));
		w5.Position = 0;
		// Container child ContenedorBotones.Gtk.Box+BoxChild
		this.btnIniciar = new global::Gtk.Button ();
		this.btnIniciar.WidthRequest = 125;
		this.btnIniciar.CanFocus = true;
		this.btnIniciar.Name = "btnIniciar";
		this.btnIniciar.UseUnderline = true;
		this.btnIniciar.Label = global::Mono.Unix.Catalog.GetString ("Iniciar Servidor");
		this.ContenedorBotones.Add (this.btnIniciar);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.ContenedorBotones [this.btnIniciar]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child ContenedorBotones.Gtk.Box+BoxChild
		this.btnTerminar = new global::Gtk.Button ();
		this.btnTerminar.WidthRequest = 125;
		this.btnTerminar.CanFocus = true;
		this.btnTerminar.Name = "btnTerminar";
		this.btnTerminar.UseUnderline = true;
		this.btnTerminar.Label = global::Mono.Unix.Catalog.GetString ("Terminar Servidor");
		this.ContenedorBotones.Add (this.btnTerminar);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.ContenedorBotones [this.btnTerminar]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child ContenedorBotones.Gtk.Box+BoxChild
		this.labelEstadoServidor = new global::Gtk.Label ();
		this.labelEstadoServidor.WidthRequest = 125;
		this.labelEstadoServidor.Name = "labelEstadoServidor";
		this.labelEstadoServidor.Xalign = 1F;
		this.labelEstadoServidor.LabelProp = global::Mono.Unix.Catalog.GetString ("\n");
		this.labelEstadoServidor.UseMarkup = true;
		this.labelEstadoServidor.Wrap = true;
		this.labelEstadoServidor.Justify = ((global::Gtk.Justification)(2));
		this.ContenedorBotones.Add (this.labelEstadoServidor);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.ContenedorBotones [this.labelEstadoServidor]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		this.ContenedorSuperior.Add (this.ContenedorBotones);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.ContenedorSuperior [this.ContenedorBotones]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.ContenedorVentana.Add (this.ContenedorSuperior);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.ContenedorVentana [this.ContenedorSuperior]));
		w10.Position = 0;
		w10.Fill = false;
		// Container child ContenedorVentana.Gtk.Box+BoxChild
		this.ContenedorMedio = new global::Gtk.VBox ();
		this.ContenedorMedio.HeightRequest = 315;
		this.ContenedorMedio.Name = "ContenedorMedio";
		this.ContenedorMedio.Spacing = 6;
		// Container child ContenedorMedio.Gtk.Box+BoxChild
		this.Grupo2 = new global::Gtk.HBox ();
		this.Grupo2.Name = "Grupo2";
		this.Grupo2.Spacing = 6;
		// Container child Grupo2.Gtk.Box+BoxChild
		this.labelRegistro = new global::Gtk.Label ();
		this.labelRegistro.Name = "labelRegistro";
		this.labelRegistro.LabelProp = global::Mono.Unix.Catalog.GetString ("Registro Actividades:");
		this.labelRegistro.UseMarkup = true;
		this.labelRegistro.Wrap = true;
		this.Grupo2.Add (this.labelRegistro);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.Grupo2 [this.labelRegistro]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child Grupo2.Gtk.Box+BoxChild
		this.hseparator3 = new global::Gtk.HSeparator ();
		this.hseparator3.Name = "hseparator3";
		this.Grupo2.Add (this.hseparator3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.Grupo2 [this.hseparator3]));
		w12.Position = 1;
		this.ContenedorMedio.Add (this.Grupo2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.ContenedorMedio [this.Grupo2]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child ContenedorMedio.Gtk.Box+BoxChild
		this.RegistroEventos = new global::Gtk.VBox ();
		this.RegistroEventos.Name = "RegistroEventos";
		this.RegistroEventos.Spacing = 6;
		// Container child RegistroEventos.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textviewRegistro = new global::Gtk.TextView ();
		this.textviewRegistro.CanFocus = true;
		this.textviewRegistro.Name = "textviewRegistro";
		this.GtkScrolledWindow.Add (this.textviewRegistro);
		this.RegistroEventos.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.RegistroEventos [this.GtkScrolledWindow]));
		w15.Position = 0;
		this.ContenedorMedio.Add (this.RegistroEventos);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.ContenedorMedio [this.RegistroEventos]));
		w16.Position = 1;
		// Container child ContenedorMedio.Gtk.Box+BoxChild
		this.ContenedorMensajes = new global::Gtk.VBox ();
		this.ContenedorMensajes.Name = "ContenedorMensajes";
		this.ContenedorMensajes.Spacing = 6;
		// Container child ContenedorMensajes.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Mensajes: ");
		this.label8.UseMarkup = true;
		this.label8.Wrap = true;
		this.hbox10.Add (this.label8);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.label8]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.hseparator4 = new global::Gtk.HSeparator ();
		this.hseparator4.Name = "hseparator4";
		this.hbox10.Add (this.hseparator4);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.hseparator4]));
		w18.Position = 1;
		this.ContenedorMensajes.Add (this.hbox10);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.ContenedorMensajes [this.hbox10]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child ContenedorMensajes.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textviewMensajes = new global::Gtk.TextView ();
		this.textviewMensajes.CanFocus = true;
		this.textviewMensajes.Name = "textviewMensajes";
		this.GtkScrolledWindow1.Add (this.textviewMensajes);
		this.ContenedorMensajes.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.ContenedorMensajes [this.GtkScrolledWindow1]));
		w21.Position = 1;
		// Container child ContenedorMensajes.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.hbox11.Add (this.entry1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.entry1]));
		w22.Position = 0;
		// Container child hbox11.Gtk.Box+BoxChild
		this.btnEnviar = new global::Gtk.Button ();
		this.btnEnviar.CanFocus = true;
		this.btnEnviar.Name = "btnEnviar";
		this.btnEnviar.UseUnderline = true;
		this.btnEnviar.Label = global::Mono.Unix.Catalog.GetString ("Enviar");
		this.hbox11.Add (this.btnEnviar);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.btnEnviar]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		this.ContenedorMensajes.Add (this.hbox11);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.ContenedorMensajes [this.hbox11]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		this.ContenedorMedio.Add (this.ContenedorMensajes);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.ContenedorMedio [this.ContenedorMensajes]));
		w25.Position = 2;
		this.ContenedorVentana.Add (this.ContenedorMedio);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.ContenedorVentana [this.ContenedorMedio]));
		w26.Position = 1;
		// Container child ContenedorVentana.Gtk.Box+BoxChild
		this.vbox53 = new global::Gtk.VBox ();
		this.vbox53.Name = "vbox53";
		this.vbox53.Spacing = 6;
		// Container child vbox53.Gtk.Box+BoxChild
		this.hseparator5 = new global::Gtk.HSeparator ();
		this.hseparator5.Name = "hseparator5";
		this.vbox53.Add (this.hseparator5);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox53 [this.hseparator5]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox53.Gtk.Box+BoxChild
		this.btnCerrar = new global::Gtk.Button ();
		this.btnCerrar.CanFocus = true;
		this.btnCerrar.Name = "btnCerrar";
		this.btnCerrar.UseUnderline = true;
		this.btnCerrar.Label = global::Mono.Unix.Catalog.GetString ("Cerrar Venana");
		this.vbox53.Add (this.btnCerrar);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox53 [this.btnCerrar]));
		w28.Position = 1;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox53.Gtk.Box+BoxChild
		this.labelCreditos = new global::Gtk.Label ();
		this.labelCreditos.Name = "labelCreditos";
		this.labelCreditos.LabelProp = global::Mono.Unix.Catalog.GetString ("Desarrollado por César Ortiz y Lukas Gómez | ® 2013");
		this.vbox53.Add (this.labelCreditos);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox53 [this.labelCreditos]));
		w29.PackType = ((global::Gtk.PackType)(1));
		w29.Position = 2;
		w29.Expand = false;
		w29.Fill = false;
		this.ContenedorVentana.Add (this.vbox53);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.ContenedorVentana [this.vbox53]));
		w30.Position = 2;
		w30.Expand = false;
		w30.Fill = false;
		this.fixed1.Add (this.ContenedorVentana);
		global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ContenedorVentana]));
		w31.X = 8;
		w31.Y = 6;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 522;
		this.DefaultHeight = 465;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnIniciar.Clicked += new global::System.EventHandler (this.btn_Iniciar_Clicked);
		this.btnTerminar.Clicked += new global::System.EventHandler (this.btnTerminar_Clicked);
		this.btnEnviar.Clicked += new global::System.EventHandler (this.btn_Enviar_Clicked);
		this.btnCerrar.Clicked += new global::System.EventHandler (this.btnCerrar_Clicked);
	}
}
