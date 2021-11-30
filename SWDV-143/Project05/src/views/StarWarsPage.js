import React from 'react';
import { POSTER_SIZE, IMAGE_BASE_URL, } from '../config.js';

import Grid from '../components/NewGrid.js'
import Thumbnail from '../components/Thumbnail.js'

import { useStarWarsFetch } from '../hooks/StarWarsFetch.js';

import NoImage from '../images/no_image.jpg';

const StarWarsPage = () => {

  const { state } = useStarWarsFetch();

  return (
    <>
    <br/>
      <Grid header='STAR WARS' >
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

export default StarWarsPage;
