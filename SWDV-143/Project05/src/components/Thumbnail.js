import React from 'react';

import { Image } from '../styles/thumbnailStyles.js';

const Thumbnail = ({ image }) => (
    <div>
        <Image src={image} alt='movie-thumbnail' />
    </div>
)

export default Thumbnail;