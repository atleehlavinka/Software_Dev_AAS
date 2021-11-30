import styled from 'styled-components';

export const Wrapper = styled.div`
  background: #1c1c1c;
  background-size: 100%, cover;
  padding: 0px 20px 40px 20px;
`;

export const Content = styled.div`
  max-width: 1280px;
  margin: auto;
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(200px, 1fr));
  grid-gap: 2rem;
  cursor: pointer;

  h1 {
    color: #fff;

    @media screen and (max-width: 768px) {
      font-size: 1.5rem;
    }
  }
`;
