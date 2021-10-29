import styled from 'styled-components';

export const Wrapper = styled.div`
  display: flex;
  align-items: center;
  height: 100px;
  background: #1c1c1c;
  padding: 0 20px 0 20px;
`;

export const Content = styled.div`
  position: relative;
  max-width: 1280px;
  width: 100%;
  height: 55px;
  background: #353535;
  margin: auto;
  border-radius: 10px;
  color: #eee;

  input {
    font-size: 1.5rem;
    position: absolute;
    left: 0px;
    margin-top: 8px;
    padding-left: 60px;
    border: none;
    width: 100%;
    background: transparent;
    height: 40px;
    color: #eee;

    :focus {
      outline: none;
    }

    :hover {
      opacity: 0.75;
    }
  }
`;
