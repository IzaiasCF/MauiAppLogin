namespace MauiAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			List<DadosUsuario> lista_usuarios = new List<DadosUsuario>()
		    { 
					new DadosUsuario()
					{
						Usuario = "José",
						Senha = "123"
					},
					new DadosUsuario()
					{
						Usuario = "Maria",
						Senha = "321"
					}
			};

			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};

			// LINQ
			if(lista_usuarios.Any(i => (dados_digitados.Usuario == i.Usuario && dados_digitados.Senha == i.Senha) ))
			{

			}

		}
		catch (Exception ex) 
		{
			DisplayAlert("Ops!", ex.Message, "Fechar");
		}
    }
}