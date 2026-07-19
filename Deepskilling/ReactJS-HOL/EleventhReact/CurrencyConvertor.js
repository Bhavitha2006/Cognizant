import React, { Component } from "react";

class CurrencyConvertor extends Component {

    constructor() {

        super();

        this.state = {

            amount: "",

            currency: "Euro"

        };

    }

    handleAmount = (event) => {

        this.setState({

            amount: event.target.value

        });

    }

    handleSubmit = () => {

        const result = this.state.amount * 80;

        alert("Converting to Euro Amount is " + result);

    }

    render() {

        return (

            <div>

                <h1 style={{color:"green"}}>

                    Currency Convertor!!!

                </h1>

                <table>

                    <tbody>

                        <tr>

                            <td>Amount:</td>

                            <td>

                                <input

                                    type="number"

                                    value={this.state.amount}

                                    onChange={this.handleAmount}

                                />

                            </td>

                        </tr>

                        <tr>

                            <td>Currency:</td>

                            <td>

                                <input

                                    type="text"

                                    value={this.state.currency}

                                    readOnly

                                />

                            </td>

                        </tr>

                        <tr>

                            <td></td>

                            <td>

                                <button onClick={this.handleSubmit}>

                                    Submit

                                </button>

                            </td>

                        </tr>

                    </tbody>

                </table>

            </div>

        );

    }

}

export default CurrencyConvertor;