using CostaRicaMusicDAL.Entidades;

namespace CostaRicaMusicDAL.Data;

public static class SeedData
{
    public static List<Artista> Artistas => new()
    {
        new Artista { IdArtista = 1, Nombre = "Debussy Ensemble", Genero = "Clásica", Pais = "Costa Rica", Biografia = "Proyecto instrumental inspirado en piezas relajantes y ambientales.", ImagenUrl = "https://images.unsplash.com/photo-1507838153414-b4b713384a76" },
        new Artista { IdArtista = 2, Nombre = "Volcán Sonoro", Genero = "Indie Pop", Pais = "Costa Rica", Biografia = "Banda ficticia de indie pop con sonidos tropicales y modernos.", ImagenUrl = "https://images.unsplash.com/photo-1493225457124-a3eb161ffa5f" },
        new Artista { IdArtista = 3, Nombre = "Pacífico Beats", Genero = "Lo-fi", Pais = "Costa Rica", Biografia = "Productor ficticio orientado a beats de estudio y concentración.", ImagenUrl = "https://images.unsplash.com/photo-1511379938547-c1f69419868d" }
    };

    public static List<Album> Albumes => new()
    {
        new Album { IdAlbum = 1, Titulo = "Noches de Lluvia", IdArtista = 3, Anio = 2025, PortadaUrl = "https://images.unsplash.com/photo-1493225457124-a3eb161ffa5f" },
        new Album { IdAlbum = 2, Titulo = "Rutas del Sol", IdArtista = 2, Anio = 2026, PortadaUrl = "https://images.unsplash.com/photo-1470229722913-7c0e2dbbafd3" },
        new Album { IdAlbum = 3, Titulo = "Piano y Bruma", IdArtista = 1, Anio = 2024, PortadaUrl = "https://images.unsplash.com/photo-1507838153414-b4b713384a76" }
    };

    public static List<Cancion> Canciones => new()
    {
        new Cancion { IdCancion = 1, Nombre = "Aurora Lenta", IdArtista = 3, IdAlbum = 1, Duracion = "03:12", AudioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3", ImagenUrl = "https://images.unsplash.com/photo-1511379938547-c1f69419868d" },
        new Cancion { IdCancion = 2, Nombre = "Café y Código", IdArtista = 3, IdAlbum = 1, Duracion = "02:58", AudioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-2.mp3", ImagenUrl = "https://images.unsplash.com/photo-1511379938547-c1f69419868d" },
        new Cancion { IdCancion = 3, Nombre = "Brisa en San José", IdArtista = 2, IdAlbum = 2, Duracion = "03:45", AudioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-3.mp3", ImagenUrl = "https://images.unsplash.com/photo-1470229722913-7c0e2dbbafd3" },
        new Cancion { IdCancion = 4, Nombre = "Kilómetro 27", IdArtista = 2, IdAlbum = 2, Duracion = "04:05", AudioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-4.mp3", ImagenUrl = "https://images.unsplash.com/photo-1470229722913-7c0e2dbbafd3" },
        new Cancion { IdCancion = 5, Nombre = "Neblina Azul", IdArtista = 1, IdAlbum = 3, Duracion = "05:21", AudioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-5.mp3", ImagenUrl = "https://images.unsplash.com/photo-1507838153414-b4b713384a76" },
        new Cancion { IdCancion = 6, Nombre = "Pausa", IdArtista = 1, IdAlbum = 3, Duracion = "04:44", AudioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-6.mp3", ImagenUrl = "https://images.unsplash.com/photo-1507838153414-b4b713384a76" }
    };

    public static List<Usuario> Usuarios => new()
    {
        new Usuario { IdUsuario = 1, Nombre = "Administrador", Email = "admin@crmusic.com", Password = "Admin123!", Rol = "Administrador" },
        new Usuario { IdUsuario = 2, Nombre = "Usuario Demo", Email = "user@crmusic.com", Password = "User123!", Rol = "Usuario" }
    };

    public static List<Playlist> Playlists => new()
    {
        new Playlist { IdPlaylist = 1, Nombre = "Favoritas", Descripcion = "Playlist inicial de prueba", UsuarioEmail = "user@crmusic.com", CancionesIds = new List<int> { 1, 3 } }
    };
}
