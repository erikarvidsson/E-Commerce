// import React from 'react';
import React, { Component } from 'react';
// import styled from 'styled-components';
import PropTypes from 'prop-types';

const Products2 = (props) => {
  return (
    <div>
      {props.text.map(product => {
        return(
          <div>
            <h1>{product.name}</h1>
            <p>{product.description}</p>
            <p>{product.price}KR</p>
            <img></img>
          </div>
        )
      })}
    </div>
  );
}

export default Products2;
