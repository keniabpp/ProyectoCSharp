namespace Application.Features.Usuarios.DTOs
{
    public class UsuarioLoginResponseDTO
    {
        public string Token { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
    }
}
