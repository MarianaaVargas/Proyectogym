using Gym.Shared.Entidades;

public class RolesUsuario
{

    public int id { get; set; }

    public int usuario_id { get; set; }

    public Usuarios usuario { get; set; }

    public int Id_Rol {  get; set; }

    public Rol rol { get; set; }

}