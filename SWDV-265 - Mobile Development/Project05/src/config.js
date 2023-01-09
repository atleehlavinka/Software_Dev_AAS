// Configuration for API
// API Documentation: https://developers.themoviedb.org/
const API_URL = 'https://api.themoviedb.org/3/';
const API_KEY = '72f24cfceb23334544955af8e86099af';

const SEARCH_BASE_URL = `${API_URL}search/movie?api_key=${API_KEY}&language=en-US&query=`;
const POPULAR_BASE_URL = `${API_URL}movie/popular?api_key=${API_KEY}&language=en-US`;
const REQUEST_TOKEN_URL = `${API_URL}authentication/token/new?api_key=${API_KEY}`;
const LOGIN_URL = `${API_URL}authentication/token/validate_with_login?api_key=${API_KEY}`;
const SESSION_ID_URL = `${API_URL}authentication/session/new?api_key=${API_KEY}`;
const IMAGE_BASE_URL = 'http://image.tmdb.org/t/p/';
const BACKDROP_SIZE = 'w1280';
const POSTER_SIZE = 'w780';

//Custom Configuration
const MAIN_MOVIE_URL = 'https://www.imdb.com/title/tt1160419/';
const MOVIE_DB_DOCUMENTATION = 'https://developers.themoviedb.org/3/getting-started';

export {
  SEARCH_BASE_URL,
  POPULAR_BASE_URL,
  API_URL,
  API_KEY,
  IMAGE_BASE_URL,
  BACKDROP_SIZE,
  POSTER_SIZE,
  REQUEST_TOKEN_URL,
  LOGIN_URL,
  SESSION_ID_URL,

  //Custom Configuration
  MAIN_MOVIE_URL,
  MOVIE_DB_DOCUMENTATION
};
