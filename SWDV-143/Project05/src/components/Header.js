import React from 'react';

import TMDBLogoImg from '../images/tmdb_logo.svg';

import { BiCameraMovie } from 'react-icons/bi';

import { MOVIE_DB_DOCUMENTATION } from '../config.js';

import { Wrapper, Content, TMDBLogo } from '../styles/headerStyles.js';

const Header = () => (
  <Wrapper>
    <Content>
      <a href="">
        <BiCameraMovie 
          style={{
            color: 'white', 
            width: "40px", 
            height: "40px"
          }} 
        />
      </a>
      <h2>We've Got the Movies!</h2>
      <a href={MOVIE_DB_DOCUMENTATION} target="blank">
        <TMDBLogo src={TMDBLogoImg} alt="tmdb-logo" />
      </a>
    </Content>
  </Wrapper>
);

export default Header;
