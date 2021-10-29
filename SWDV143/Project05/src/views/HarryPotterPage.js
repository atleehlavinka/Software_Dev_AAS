import React from 'react';
import { POSTER_SIZE, IMAGE_BASE_URL} from '../config.js';

import Grid from '../components/Grid.js'
import Thumbnail from '../components/Thumbnail.js'

import { useHarryPotterFetch } from '../hooks/HarryPotterFetch.js';

import NoImage from '../images/no_image.jpg';

const HarryPotterPage = () => {

  const { state } = useHarryPotterFetch();

  return (
    <>
      <Grid header='Harry Potter' >
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

export default HarryPotterPage;
