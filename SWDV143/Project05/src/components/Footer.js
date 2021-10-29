import React from 'react';

import { Wrapper, Content } from '../styles/footerStyles.js';

import { FaTwitter } from 'react-icons/fa';
import { FaReddit } from 'react-icons/fa';
import { FaFacebook } from 'react-icons/fa';
import { FaInstagram } from 'react-icons/fa';


const Header = () => (
  <Wrapper>
    <Content>
      <a href="www.facebook.com" target="_blank">
        <span>
          <FaFacebook 
            style={{
              width: "35px",
              height: "35px",
              margin: "10px 10px 10px 10px"
            }}
          />
        </span>
      </a>
      <a href="www.facebook.com" target="_blank">
        <span>
          <FaInstagram 
            style={{
              width: "35px",
              height: "35px",
              margin: "10px 10px 10px 10px"
            }}
          />
        </span>
      </a>
      <a href="www.facebook.com" target="_blank">
        <span>
          <FaTwitter 
            style={{
              width: "35px",
              height: "35px",
              margin: "10px 10px 10px 10px"
            }}
          />
        </span>
      </a>
      <a href="www.facebook.com" target="_blank">
        <span>
          <FaReddit 
            style={{
              width: "35px",
              height: "35px",
              margin: "10px 10px 10px 10px"
            }}
          />
        </span>
      </a>
    </Content>
  </Wrapper>
);

export default Header;
