namespace MassCultureLibrary.Animes
{
    public class AnimeService : IAnimeService
    {
        IAnimeRepository _repository;

        public AnimeService(IAnimeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Anime> AddAnimeAsync(Anime anime)
            => await _repository.AddAsync(anime);

        public async Task DeleteAnimeAsync(Guid animeId)
            => await _repository.DeleteAsync(animeId);

        public async Task<IEnumerable<Anime>> GetAnimeAsync() 
            => await _repository.GetAllAsync();

        public async Task<Anime?> GetAnimeByIdAsync(Guid animeId)
            => await _repository.GetByIdAsync(animeId);

        public async Task<IEnumerable<Anime>> GetAnimeByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public async Task<Anime> UpdateAnimeAsync(Guid animeId, AnimeUpdateDto updateInfo)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UpdateAnimeNameAsync(string name)
            => await _repository.UpdateAnimeNameAsync(name);
    }
}
