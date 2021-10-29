import styled from 'styled-components';

export const Wrapper = styled.div`
  max-width: 1280px;
  margin: auto;
  padding: 0 20px 60px 0px;

  h1 {
    color: #353535;

    @media screen and (max-width: 768px) {
      font-size: 1.5rem;
    }
  }
`;

export const Spinner = styled.div`
  border: 5px solid #eee;
  border-top: 5px solid #353535;
  border-radius: 50%;
  width: 50px;
  height: 50px;
  animation: loading 1.0s linear infinite;
  margin: auto;

  @keyframes loading {
    0% {
      transform: rotate(0deg);
    }
    100% {
      transform: rotate(360deg);
    }
  }
`;
