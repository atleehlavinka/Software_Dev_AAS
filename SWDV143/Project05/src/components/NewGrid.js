import React from "react";

import { Wrapper, Content } from '../styles/newGridStyles.js';

const Grid = ({ header, children }) => (
    <Wrapper>
        <Content><h1>{header}</h1></Content>
        <Content>{children}</Content>
    </Wrapper>
)

export default Grid;
