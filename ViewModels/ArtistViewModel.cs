namespace MusicStore.ViewModels
{
    using MusicStore.Models;
    using System.Collections.Generic;

    public class ArtistViewModel
    {
        public List<Artist> Artists { get; set; } = new();
        public List<Album> Albums { get; set; } = new();
    }
}
