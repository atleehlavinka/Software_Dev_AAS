import styled from 'styled-components';

export const Wrapper = styled.div`
  background: #1c1c1c;
  padding: 0px 20px 0px 20px;
`;

export const Content = styled.div`
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-left: auto;
  margin-right: auto;
  height: 90px;
  max-width: 250px;


  a {
      color: white;
  }

  a span:hover {
    opacity: 0.6;
    cursor: pointer;
  }

`;
