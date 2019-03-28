import React, { Component } from 'react';
import PropTypes from 'prop-types'
import './Products.css';
import Button from '../Button'
class Products extends Component {
  state = {
      products: [],
      guid: []
    }

    componentDidMount() {
      this.fetchApi();
      this.fetchCartId();
    }

    fetchApi = () => {
      const api = 'http://localhost:28071/api/items';

      fetch(api)
      .then(res => res.json())
      .then(item =>{
        // data.map(item => {
        this.setState({
          products: item
        })
      // })
      })
    }

    fetchCartId = () => {
      const guid = 'http://localhost:28071/api/myGuid';

      fetch(guid)
      .then(res => res.json())
      .then(guid =>{
        // data.map(item => {
        this.setState({
          guid: guid
        })
      // })
      })
    }



    handleSubmit(e){
        e.preventDefault();

        const id = e.target[0].value;

        let myGuid =  localStorage.getItem("myGuid")

        if(myGuid == null){
          let guid = e.target[1].value;
          localStorage.setItem("myGuid", guid)
        }
       let guid = localStorage.getItem("myGuid")
      const send = {guid: guid, product_id: id }
                  fetch('http://localhost:28071/api/Cart', {
                  headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                  },
                  method: 'POST',
                  body: JSON.stringify(send),
                  mode: 'cors'
                })

        console.log(send)
    }



    render() {
      // console.log(this.state.products)
      // console.log(this.state.guid)  
      // const names = this.state.products.name
      // const names = this.state.products.name
      // const price = this.state.products.price
      // console.log(names);
      // console.log(price);
      return (
        <div className="ProductsContainer">
          {this.state.products.map((item, key) =>
              <div className="ProductBox" key={key}>
                <h2>{item.name} </h2>
                <p>{item.price}kr </p>
                <p className="description">{item.description}kr </p>
                <img src={item.img_url} />
              <div className="Button">
                <Button> ADD </Button>
              </div>
              <div>
                <form onSubmit={this.handleSubmit} action="index.html">
                   <input type="hidden" name="id" value={item.id} />
                   <input type="hidden" name="cart_guid" value={this.state.guid} />
                   <button type="submit" className="cta-buyBtn">Add to cart</button>
                </form>

              </div>
            </div>
          )}
        </div>
                // <form  action="index.html">
                //   <input type="text" name="name" />
                //   <input type="text" name="adress" />
                //   <input type="text" name="phone" />
                //   <button type="submit">Add to cart</button>
                // </form>

      );
    }


}

export default Products;
