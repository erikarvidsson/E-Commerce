import React, { Component } from 'react';
import PropTypes from 'prop-types'


class Cart extends Component {
  state = {
      cart: [],
      products: [],
      myGuid:  localStorage.getItem("myGuid")
    }

    componentDidMount() {
      this.fetchCart();
      this.fetchProduct();
    }


    fetchCart = () => {
      const cart = 'http://localhost:28071/api/Cart';

      fetch(cart)
      .then(res => res.json())
      .then(cart =>{
        // cart.map(item => {
        this.setState({
          cart: cart
        })
      // })
      })
    }


    fetchProduct = () => {
      const products = `http://localhost:28071/api/orders/${this.state.myGuid}`;

      fetch(products)  
      .then(res => res.json())
      .then(products =>{
        // data.map(item => {
        this.setState({
          products: products
        })
      // })
      })
    }


    render() {
      console.log("---------------------")
        console.log(this.state.products)
      console.log("---------------------")
      return (
        <div className="ProductsContainer">
        {this.state.products.map((item, key) =>
            <div className="ProductBox" key={key}>
              <h2>{item.name} </h2>
              <p>{item.price}kr </p>
              <p className="description">{item.description}kr </p>
              <img src={item.img_url} />
            <div className="Button">
              {/* <Button> ADD </Button> */}
            </div>
            {/* <div>
              <form onSubmit={this.handleSubmit} action="index.html">
                 <input type="hidden" name="id" value={item.id} />
                 <input type="hidden" name="cart_guid" value={this.state.guid} />
                 <button type="submit" className="cta-buyBtn">Add to cart</button>
              </form>
            </div> */}
          </div>
        )}
      </div>
      );
    }


}

export default Cart;
