import styled from 'styled-components';

export const Wrapper = styled.div`
  background: #1c1c1c;
  padding: 0 20px 0px 20px;
`;

export const Content = styled.div`
  display: flex;
  align-items: center;
  justify-content: space-between;
  max-width: 1280px;
  padding: 20px 0 20px 0px;
  margin: auto;

  h2 {
    color: white;
  }

  a:hover {
    opacity: 0.6;
  }

`;

export const TMDBLogo = styled.img`
width: 100px;

:hover {
      opacity: 0.6;
      cursor:  pointer;
    }
`;
