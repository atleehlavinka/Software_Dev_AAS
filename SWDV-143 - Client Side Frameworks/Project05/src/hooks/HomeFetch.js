import { useState, useEffect } from 'react'
import API from '../API.js';

const initialState = {
    page: 0,
    results: [],
    total_pages: 0,
    total_results: 0
}

export const useHomeFetch = () => {
  
    const [state, setState] = useState(initialState);

    const fetchMovies = async (page, searchTerm = '') => {

      const movies = await API.fetchMovies(searchTerm, page);

      setState(prev => ({
        ...movies,
        results: page > 1 ? [...prev.results, ...movies.results] : [...movies.results],
      }));
    };
  
    useEffect(() => {
      fetchMovies(1);
    }, []);

    return { state };
}