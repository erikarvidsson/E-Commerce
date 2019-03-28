import React, { Component } from 'react';
import './App.css';
import Products from './components/Products'
import Cart from './components/Cart'


class App extends Component {
  render() {
    return (
      <div className="App">
        <Products>
        </Products>
        <Cart />
      </div>
    );
  }
}

export default App;
