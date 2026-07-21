import React, { Component } from "react";

class Getuser extends Component {

    constructor() {

        super();

        this.state = {

            person: {},

            loading: true

        };

    }

    async componentDidMount() {

        const url = "https://api.randomuser.me/";

        const response = await fetch(url);

        const data = await response.json();

        this.setState({

            person: data.results[0],

            loading: false

        });

        console.log(data.results[0]);

    }

    render() {

    return (

        <div className="container">

            <h1>Mr Donato Nunes</h1>

            <img
                src="https://replacementcarkeyfortworth.com/images/virgil-berry.webp"
                alt="User"
                width="160"
                height="160"
            />

        </div>

    );


    }

}

export default Getuser;