import styled from 'styled-components';

export const Image = styled.img`
  width: 100%;
  max-width: 1280px;
  transition: all 0.9s;
  border-radius: 30px;
  animation: loadThumbnail 0.75s;

  :hover {
    opacity: 0.6;
    padding: 5px 5px 5px 5px;
  }

  @keyframes loadThumbnail {
    from {
      opacity: 0.4;
    }
    to {
      opacity: 1;
    }
  }
`;
