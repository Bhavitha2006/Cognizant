import React, { Component } from "react";
import Cart from "./Cart";
import "./App.css";

class OnlineShopping extends Component {

    constructor() {

        super();

        this.items = [

            new Cart("Laptop", 80000),
            new Cart("TV", 120000),
            new Cart("Washing Machine", 50000),
            new Cart("Mobile", 30000),
            new Cart("Fridge", 70000)

        ];

    }

    render() {

        return (

            <div className="container">

                <h1>Items Ordered :</h1>

                <table>

                    <thead>

                        <tr>

                            <th>Name</th>

                            <th>Price</th>

                        </tr>

                    </thead>

                    <tbody>

                        {

                            this.items.map((item, index) => (

                                <tr key={index}>

                                    <td>{item.itemName}</td>

                                    <td>{item.price}</td>

                                </tr>

                            ))

                        }

                    </tbody>

                </table>

            </div>

        );

    }

}

export default OnlineShopping;