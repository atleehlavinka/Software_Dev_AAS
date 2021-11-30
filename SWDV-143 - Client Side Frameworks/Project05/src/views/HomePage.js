import React from 'react';
import { POSTER_SIZE, BACKDROP_SIZE, IMAGE_BASE_URL, MAIN_MOVIE_URL } from '../config.js';

import HeroImage from '../components/HeroImage.js';
import Grid from '../components/Grid.js'
import Thumbnail from '../components/Thumbnail.js'
import SearchBar from '../components/SearchBar.js';

import { useHomeFetch } from '../hooks/HomeFetch.js';

import NoImage from '../images/no_image.jpg';

const HomePage = () => {

  const { state } = useHomeFetch();

  return (
    <>
      {state.results[0] ? (
        <a href={MAIN_MOVIE_URL} target="_blank" rel="noreferrer">
          <HeroImage  image={`${IMAGE_BASE_URL}${BACKDROP_SIZE}${state.results[0].backdrop_path}`}
                      title={state.results[0].original_title}
                      text={state.results[0].overview}/>
        </a>
      )  : null}
      <SearchBar />
      <Grid header='Popular Movies' >
        {state.results.map(movie => (
          <Thumbnail key={movie.id} clickable image={
            movie.poster_path
              ? IMAGE_BASE_URL + POSTER_SIZE + movie.poster_path
              : NoImage
          } movieId={movie.id}/>
        ))}
      </Grid>
    </>
  );
};

export default HomePage;
