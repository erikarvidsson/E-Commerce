import React, { Component } from 'react';
import PropTypes from 'prop-types';
import styled from 'styled-components';


const Button = styled.div `
    background-color: #8a899f;
    border: 0px solid black;
    border-radius: 14px;
    padding-top: 7px;
    font-weight: 500;
    width: 140px;
    height 30px;
    font-size: 18px;
    color: white;
    transition: all 0.5s;

    &:hover{
      transition: 0.5s;
      box-shadow: 0px 0px 30px 3px #545365;
      text-shadow: 0px 0px 30px 3px #fffff;
      width: 150px;
      height: 30px;
    }
`

const showAlert = () => {

}

const TestButton = (props) => {
  return(
    <div>
      <Button> inverted={props.inverted} </Button>
    </div>
  )
}

Button.propTypes = {
  inverted: PropTypes.bool
}
export default Button;
