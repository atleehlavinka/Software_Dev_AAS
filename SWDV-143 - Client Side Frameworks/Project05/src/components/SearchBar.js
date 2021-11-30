import React from 'react';

import { FaSearch } from 'react-icons/fa';

import { Wrapper, Content } from '../styles/searchbarStyles.js';

const SearchBar = () => {
    return (
        <Wrapper>
          <Content>
            <FaSearch 
                style={{
                    color: 'white', 
                    width: "30px", 
                    height: "55px",
                    'margin-left': "15px"
                }}
            />
            <input type='text' placeholder='Search Coming Soon' />
          </Content>
        </Wrapper>
    );
};

export default SearchBar;
