import React from 'react';

import './styles/mainStyles.css';

import Header from './components/Header.js';
import HomePage from './views/HomePage.js';
import LoadingPage from './views/LoadingPage.js';
import StarWarsPage from './views/StarWarsPage.js';
import HarryPotterPage from './views/HarryPotterPage.js';
import LegoPage from './views/LegoPage.js'
import Footer from './components/Footer.js';

function App() {
  return (
    <div className="App">

      <Header />
        <HomePage />
        <StarWarsPage />
        <HarryPotterPage />
        <LegoPage />
        <LoadingPage />
      <Footer />

    </div>
  );
}

export default App;
