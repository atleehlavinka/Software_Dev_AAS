import styled from 'styled-components';

export const Wrapper = styled.div`
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0) 41%, rgba(0, 0, 0, 0.65) 100%), url(${({ image }) => image}), #1c1c1c;
  background-size: 100%, cover;
  background-position: 50% 20%;
  height: 50vh;
  position: relative;
  animation: animateHeroImage 1s;

  :hover {
    opacity: 0.95;
  }

  @keyframes animateHeroImage {
    from {
      opacity: 0.75;
    }
    to {
      opacity: 1;
    }
  }
`;

export const Content = styled.div`
  padding: 20px 20px 20px 20px;
  max-width: 1280px;
  margin: auto;
`;

export const Text = styled.div`
  max-width: 1280px;
  position: absolute;
  bottom: 20px;
  margin-right: 20px;
  min-height: 100px;
  color: #fff;

  h1 {
    font-size: 3.5rem;
    text-align: center;

    @media screen and (max-width: 720px) {
      font-size: 1.5rem;
    }

    :hover {
      opacity: 0.6;
      cursor:  pointer;
    }

  }

  p {
    font-size: 1.2rem;
    text-align: left;

    :hover {
      opacity: 0.6;
      cursor:  pointer;
    }

    @media screen and (max-width: 720px) {
      font-size: 1rem;
    }
  }

  @media screen and (max-width: 720px) {
    max-width: 100%;
  }
`;
